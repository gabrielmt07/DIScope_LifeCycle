using System;

namespace DI___Life_Cycle.Services
{
    public class Operation : IOperationScoped, IOperationSingleton, IOperationTransient
    {
        public Operation()
        {
            OperationId = Guid.NewGuid().ToString();
        }

        public string OperationId { get; }
    }
}
