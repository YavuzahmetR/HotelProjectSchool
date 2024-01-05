using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Entities.Concrete
{
    public class WorkPlace
    {
        public int WorkPlaceID { get; set; }
        public string WorkPlaceName { get; set; }
        public string WorkPlaceCity { get; set; }
        public List<AppUser> AppUsers { get; set; } 
    }
}
