using Microsoft.AspNetCore.Http;

namespace Startup.Middlewares
{
    public class Foo:MiddlewareBase
    {
        public Foo(RequestDelegate next) : base(next)
        {
        }
    }
}