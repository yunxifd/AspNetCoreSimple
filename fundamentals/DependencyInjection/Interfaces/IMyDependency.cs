using System.Threading.Tasks;

namespace DependencyInjection.Interfaces
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}