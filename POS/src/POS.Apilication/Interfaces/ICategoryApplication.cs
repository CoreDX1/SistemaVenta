using POS.Apilication.Commons.Bases;
using POS.Apilication.Dtos.Request;
using POS.Apilication.Dtos.Response;
using POS.Infrastructure.Commons.Base.Request;
using POS.Infrastructure.Commons.Base.Response;
using POS.Infrastructure.Persistences.Repositories;

namespace POS.Apilication.Interfaces;

// Metodos para el crud?
public interface ICategoryApplication
{
    Task<BaseResponse<BaseEntityReponse<CategoryRepository>>> ListCategory(
        BaseFilterRequest filter
    );
    Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategories();
    Task<BaseResponse<CategoryReponseDto>> CategoryById(int catetory);
    Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDto requestDto);
    Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDto requestDto);
    Task<BaseResponse<bool>> RemoveCategory(int categoryId);
}
