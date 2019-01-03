using Microsoft.AspNetCore.Http;

namespace Startup.Middlewares
{
    public class Baz:MiddlewareBase
    {
        public Baz(RequestDelegate next) : base(next)
        {
        }
    }
}