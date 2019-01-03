using Microsoft.AspNetCore.Http;

namespace Startup.Middlewares
{
    public class Gux:MiddlewareBase
    {
        public Gux(RequestDelegate next) : base(next)
        {
        }
    }
}