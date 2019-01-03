using System.Threading.Tasks;
using DependencyInjection.Interfaces;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class Index : PageModel
    {
        private readonly IMyDependency _myDependency;
        public OperationService OperationService { get; }
        public IOperationTransient TransientOperation { get; }
        public IOperationScoped ScopedOperation { get; }
        public IOperationSingleton SingletonOperation { get; }
        public IOperationSingletonInstance SingletonInstanceOperation { get; }
        
        public Index(
            IMyDependency myDependency, 
            OperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            _myDependency = myDependency;
            OperationService = operationService;
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
            SingletonInstanceOperation = singletonInstanceOperation;
        }
        public async Task OnGetAsync()
        {
            await _myDependency.WriteMessage(
                "Index.OnGetAsync created this message.");
        }
    }
}