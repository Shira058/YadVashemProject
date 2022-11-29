using System.Net;

namespace Yad_Vashem.Middlewares;
public class HandlerErrorsMiddleware
{
    private RequestDelegate _next;
    private ILogger<HandlerErrorsMiddleware> _ILogger;

    public HandlerErrorsMiddleware(RequestDelegate next, ILogger<HandlerErrorsMiddleware> ILogger)
    {
        _next = next;
        _ILogger = ILogger;
    }
    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
            if (httpContext.Response.StatusCode > 400 && httpContext.Response.StatusCode < 500)
            {
                throw new KeyNotFoundException("Not Found");
            }

        }
        catch (Exception error)
        {
            _ILogger.Log(LogLevel.Error, error.Message);
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            
        }
    }
}

// Extension method used to add the middleware to the HTTP request pipeline.
public static class HandlerErrorsMiddlewareExtensions
{
    public static IApplicationBuilder UseHandlerErrorsMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<HandlerErrorsMiddleware>();
    }
}
