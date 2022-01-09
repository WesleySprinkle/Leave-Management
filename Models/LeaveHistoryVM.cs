using Leave_Mangement.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Mangement.Models
{
    public class LeaveHistoryVM
    {
      
        public int Id { get; set; }
       
        public Employee RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
      
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
        public Employee ApprovedBy { get; set; }

        public string ApprovedById { get; set; }
    }
}
