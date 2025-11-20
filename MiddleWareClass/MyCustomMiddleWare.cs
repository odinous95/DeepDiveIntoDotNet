
namespace LearningApp.MiddleWareClass
{
    public class MyCustomMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from MyCustomMiddleWare before \n");
            await next(context);
            await context.Response.WriteAsync("Hello from MyCustomMiddleWare after next()\n");
        }
    }
}
