using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        
        public string Name { get; set; } = string.Empty;
        
        [Display(Name = "Days off")]
        public int Days { get; set; }

    }
}