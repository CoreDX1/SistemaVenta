using POS.Infrastructure.Commons.Base;

namespace POS.Infrastructure.Helpers;

public static class QueryableHelper
{
    public static IQueryable<T> Paginate<T>(
        this IQueryable<T> queryble,
        BasePaginationRequest request
    )
    {
        return queryble.Skip((request.NumPage - 1) * request.Records).Take(request.Records);
    }
}
