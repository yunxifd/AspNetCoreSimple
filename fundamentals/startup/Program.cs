using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args) // 调用CreateWebHostBuilder 方法，配置WebHost
                .Build() // 创建 WebHost
               .Run(); // 运行
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}