using POS.Domain.Entities;
using POS.Infrastructure.Commons.Base.Request;
using POS.Infrastructure.Commons.Base.Response;

namespace POS.Infrastructure.Persistences.Interfaces;

public interface ICategoryRepository
{
    Task<BaseEntityReponse<Category>> ListCategories(BaseFilterRequest filters);

    // Select pata el lado del frond
    // Modulo de producto va ser necesario escoger una categoria , cuando se este registrando
    Task<IEnumerable<Category>> ListSelectCategories();
    Task<Category> CategoryById(int CategoryById);
    Task<bool> RegisterCategory(Category category);
    Task<bool> EditCategory(Category category);
    Task<bool> RemoveCategory(int categoryId);
}
