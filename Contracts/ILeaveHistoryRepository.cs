using Leave_Mangement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Mangement.Contracts
{
    interface ILeaveHistoryRepository:IRepositoryBase<LeaveHistory>
    {
       // ICollection<LeaveHistory> GetEmployeesByLeaveHistory(int id);
    }
}
