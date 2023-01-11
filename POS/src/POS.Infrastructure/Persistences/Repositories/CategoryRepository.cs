using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Base.Request;
using POS.Infrastructure.Commons.Base.Response;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    private readonly PostContext _context;

    public  CategoryRepository(PostContext context)
    {
        _context = context;
    }

    public async Task<BaseEntityReponse<Category>> ListCategories(BaseFilterRequest filters)
    {
        var response = new BaseEntityReponse<Category>();
        var categories = (from c in _context.Categories
           where c.AuditDeleteUser == null && c.AuditDeleteDate == null select c
        ).AsNoTracking().AsQueryable();
        if(filters.NumFilter is not null && !string.IsNullOrEmpty(filters.TextFilter)){
            switch (filters.NumFilter)
            {
                case 1:
                    categories = categories.Where(c => c.Name!.Contains(filters.TextFilter));
                    break;
                case 2:
                    categories = categories.Where(c => c.Description!.Contains(filters.TextFilter));
                    break;
            }
        }
        if(filters.StateFilter is not null) 
            categories = categories.Where(x => x.State.Equals(filters.StateFilter));
        if(!string.IsNullOrEmpty(filters.StartDate) && !string.IsNullOrEmpty(filters.EndDate)) 
            categories = categories.Where(x => x.AuditCreateDate >= Convert.ToDateTime(filters.StartDate) && x.AuditCreateDate <= Convert.ToDateTime(filters.EndDate).AddDays(1));
        if(filters.Sort is null) filters.Sort = "CategoryId";
        response.TotalRecords = await categories.CountAsync();
        response.Items = await Ordering(filters, categories, !(bool)filters.Download).ToListAsync();
        return response;
    }

    public Task<IEnumerable<Category>> ListSelectCategories()
    {
        throw new NotImplementedException();
    }

    public Task<Category> CategoryById(int CategoryById)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RegisterCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveCategory(int categoryId)
    {
        throw new NotImplementedException();
    }
}
