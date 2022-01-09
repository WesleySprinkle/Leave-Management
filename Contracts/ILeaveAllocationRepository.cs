using Leave_Mangement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Mangement.Contracts
{
    interface ILeaveAllocationRepository: IRepositoryBase<LeaveAllocation>
    {
       // ICollection<LeaveType> GetEmployeesByLeaveAllocation(int id);
    }
}
