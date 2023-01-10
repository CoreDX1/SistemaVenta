using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    private readonly PostContext _context;

    public CategoryRepository(PostContext context){
        _context = context;
    }
 }
