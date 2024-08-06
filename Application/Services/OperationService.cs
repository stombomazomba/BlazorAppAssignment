using Application.Interfaces;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services
{
    public class OperationService : IOperationService
    {
        private readonly List<Operation> _operations = new List<Operation>();

        public List<Operation> GetOperations()
        {
            return _operations;
        }

        public void AddOperation(Operation operation)
        {
            operation.OperationID = _operations.Count + 1;
            _operations.Add(operation);
        }

        public void RemoveOperation(int operationId)
        {
            var operation = _operations.FirstOrDefault(o => o.OperationID == operationId);
            if (operation != null)
            {
                _operations.Remove(operation);
            }
        }

        public void AddDeviceToOperation(int operationId, Device device)
        {
            var operation = _operations.FirstOrDefault(o => o.OperationID == operationId);
            if (operation != null)
            {
                operation.Device = device;
            }
        }
    }
}
