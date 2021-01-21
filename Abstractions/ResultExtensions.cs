namespace DIApi
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public static class ResultExtensions
    {
        public static async Task<IActionResult> ResultAsync<T>(this Task<IResult<T>> result)
        {
            return ApiResult.Create(await result.ConfigureAwait(false));
        }
    }
}