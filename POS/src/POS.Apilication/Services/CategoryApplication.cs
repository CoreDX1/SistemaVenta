using AutoMapper;
using POS.Apilication.Commons.Bases;
using POS.Apilication.Dtos.Request;
using POS.Apilication.Dtos.Response;
using POS.Apilication.Interfaces;
using POS.Apilication.Validators.Category;
using POS.Infrastructure.Commons.Base.Request;
using POS.Infrastructure.Commons.Base.Response;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Infrastructure.Persistences.Repositories;
using POS.Utilities.Static;
using System.Runtime.CompilerServices;

namespace POS.Apilication.Services;

internal class CategoryApplication : ICategoryApplication
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly CategoryValidator _validationRules;
    public CategoryApplication(IUnitOfWork unitOfWork, IMapper mapper, CategoryValidator validationRules)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _validationRules = validationRules;
    }
    public async Task<BaseResponse<BaseEntityReponse<CategoryReponseDto>>> ListCategory(
        BaseFilterRequest filter
    )
    {
        var response = new BaseResponse<BaseEntityReponse<CategoryReponseDto>>();
        var categories = await _unitOfWork.Category.ListCategories(filter);
        if(categories is not null)
        {
            response.isSuccess = true;
            response.Data = _mapper.Map<BaseEntityReponse<CategoryReponseDto>>(categories);
            response.Message = ReplyMessage.MESSAGE_QUERY;
        }
        else
        {
            response.isSuccess = false;
            response.Message = ReplyMessage.MESSAGE_QUERY_EMTY;
        }
        return response;
    }

    public async Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategories()
    {
        var response = new BaseResponse<IEnumerable<CategorySelectResponseDto>>();
        var categories = await _unitOfWork.Category.ListSelectCategories();
        if(categories is not null)
        {
            response.isSuccess = true;
            response.Data = _mapper.Map<IEnumerable<CategorySelectResponseDto>>(categories);
            response.Message = ReplyMessage.MESSAGE_QUERY;
        }
        else
        {
            response.isSuccess = false;
            response.Message = ReplyMessage.MESSAGE_QUERY_EMTY;
        }
        return response;
    }

    public async Task<BaseResponse<CategoryReponseDto>> CategoryById(int catetory)
    {
        var response = new BaseResponse<CategoryReponseDto>();
        var category = await _unitOfWork.Category.CategoryById(catetory);
        if(category is not null){
            response.isSuccess = true;
            response.Data = _mapper.Map<CategoryReponseDto>(category);
            response.Message = ReplyMessage.MESSAGE_QUERY;
        }else{
            response.isSuccess = false;
            response.Message = ReplyMessage.MESSAGE_QUERY_EMTY;
        }
        return response;
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
