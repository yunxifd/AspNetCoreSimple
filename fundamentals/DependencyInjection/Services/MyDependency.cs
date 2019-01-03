using System.Threading.Tasks;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class MyDependency : IMyDependency
    {
        public Task WriteMessage(string message)
        {
            return Task.CompletedTask;
        }
    }
}