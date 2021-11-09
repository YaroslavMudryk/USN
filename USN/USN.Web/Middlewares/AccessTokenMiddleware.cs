namespace USN.Web.Middlewares
{
    public class AccessTokenMiddleware
    {
        private readonly RequestDelegate _next;
        public AccessTokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            var token = httpContext.Request.Query["access_token"].ToString();
            if (string.IsNullOrEmpty(httpContext.Request.Headers["Authorization"]) && !string.IsNullOrEmpty(token))
            {
                httpContext.Request.Headers["Authorization"] = $"Bearer {token}";
            }
            await _next(httpContext);
        }
    }
}