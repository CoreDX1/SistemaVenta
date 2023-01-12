using FluentValidation.Results;

namespace POS.Apilication.Commons.Bases;

public class BaseResponse<T>
{
    public bool isSuccess { get; set; }
    public T? Data { get; set; }
    public string? Message { get; set; }
    public IEnumerable<ValidationFailure>? Errors { get; set; }
}
