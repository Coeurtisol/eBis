using eBis.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.common.Interfaces
{
    public interface IOperationDataProvider
    {
        List<Operation> getAllOperations();
        List<Operation> getOperationsByBorne(Borne borne);
    }
}
