namespace DIApi
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public sealed class ApiResult : IActionResult
    {
        private readonly IResult _result;

        private ApiResult(IResult result) => _result = result;

        private ApiResult(object data) => _result = Result<object>.Success(data);

        public static IActionResult Create(IResult result) => new ApiResult(result);

        public static IActionResult Create(object data) => new ApiResult(data);

        public Task ExecuteResultAsync(ActionContext context)
        {
            object value = null;

            if (_result.Failed)
            {
                value = _result.Message;
            }

            if (_result.GetType().IsGenericType && _result.GetType().GetGenericTypeDefinition() == typeof(Result<>))
            {
                value = (_result as dynamic)?.Data;
            }

            ObjectResult objectResult = new (value);

            return objectResult.ExecuteResultAsync(context);
        }
    }
}