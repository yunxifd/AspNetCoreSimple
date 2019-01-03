using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Startup.Middlewares
{
    public class MiddlewareBase
    {
        private RequestDelegate _next;

        public MiddlewareBase(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync($"{this.GetType().Name}=>");
            await _next(context);
        }
    }
}