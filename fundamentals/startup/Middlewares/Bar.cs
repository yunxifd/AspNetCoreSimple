using Microsoft.AspNetCore.Http;

namespace Startup.Middlewares
{
    public class Bar:MiddlewareBase
    {
        public Bar(RequestDelegate next) : base(next)
        {
        }
    }
}