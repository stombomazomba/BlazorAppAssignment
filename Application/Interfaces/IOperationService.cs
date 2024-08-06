using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOperationService
    {
        List<Operation> GetOperations();
        void AddOperation(Operation operation);
        void RemoveOperation(int operationId);
        void AddDeviceToOperation(int operationId, Device device);
    }
}
