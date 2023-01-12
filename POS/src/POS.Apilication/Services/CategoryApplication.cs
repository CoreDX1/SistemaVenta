using POS.Apilication.Commons.Bases;
using POS.Apilication.Dtos.Request;
using POS.Apilication.Dtos.Response;
using POS.Apilication.Interfaces;
using POS.Infrastructure.Commons.Base.Request;
using POS.Infrastructure.Commons.Base.Response;
using POS.Infrastructure.Persistences.Repositories;

namespace POS.Apilication.Services;

internal class CategoryApplication : ICategoryApplication
{
    public Task<BaseResponse<BaseEntityReponse<CategoryRepository>>> ListCategory(
        BaseFilterRequest filter
    )
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategories()
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<CategoryReponseDto>> CategoryById(int catetory)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDto requestDto)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDto requestDto)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<bool>> RemoveCategory(int categoryId)
    {
        throw new NotImplementedException();
    }
}
