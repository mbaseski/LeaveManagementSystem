using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        
        [Required]
        [Length(4, 150, ErrorMessage = "Нема соодветен број на карактери")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90)]
        [Display(Name = "Days off")]
        public int Days { get; set; }

    }
}