using AutoMapper;

using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            // Ako vo LeaveManagementSystem.Web\Models\LeaveTypes\IndexVM.cs
            //public int Days { get; set; }
            // a vo LeaveManagementSystem.Web\Data\LeaveType.cs
            //public int NumberOfDays { get; set; }
            // TOGASH GI SPOJUVAME NA SLEDNIOT NACIN:
            //
            //   reateMap<LeaveType, IndexVM>()
            //   .ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumbeOfDays));

            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
            CreateMap<LeaveTypeDeleteVM, LeaveType>().ReverseMap();

        }

    }
}
