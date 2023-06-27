using API.ApiModels;
using System.Net;
using System.Text.Json;

namespace API.Middlewares;
public class GlobalExceptionHandler : IMiddleware
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch(Exception exception)
        {
			string details;
			ErrorInformation problemInfo;
			if (exception.StackTrace is not null)
			{
				details = exception.StackTrace.ToString();
				problemInfo = new
				ErrorInformation("Internal Server Error",
				exception.Message,
				(int)HttpStatusCode.InternalServerError, details);
			}
			else
			{
				problemInfo = new
				ErrorInformation("Internal Server Error",
				exception.Message,
				(int)HttpStatusCode.InternalServerError, "No Details Provided");
			}
                
            var json = JsonSerializer.Serialize(problemInfo);
            _logger.LogError(json);
			context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
			context.Response.ContentType = "application/json";
			await context.Response.WriteAsync(json);


		}
    }
}

