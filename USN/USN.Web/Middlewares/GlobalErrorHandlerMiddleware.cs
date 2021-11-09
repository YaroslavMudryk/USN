using System.Net;

namespace USN.Web.Middlewares
{
    public class GlobalErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
                return;
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            var requestId = httpContext.TraceIdentifier;
            var response = httpContext.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            Console.WriteLine($"Error at [{httpContext.Request.Path.Value}] [{requestId}]");
            return response.WriteAsJsonAsync(new
            {
                RequestId = requestId,
                Error = exception.Message
            });
        }
    }
}