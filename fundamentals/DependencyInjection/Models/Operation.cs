using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid id)
        {
            OperationId = id;
        }

        public Guid OperationId { get; private set; }
    }
}