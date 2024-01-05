using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.DTO.Dtos.AppUser
{
    public class AppUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string? ImageUrl { get; set; }
        public string? Country { get; set; }
        public string? Gender { get; set; }
        public int WorkPlaceID { get; set; }
        public string? WorkDepartment { get; set; }
    }
}
