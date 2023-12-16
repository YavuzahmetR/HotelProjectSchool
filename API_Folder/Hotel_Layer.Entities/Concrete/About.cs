using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Entities.Concrete
{
    public class About
    {
        public int AboutID { get; set; }
        public string TitleFirst { get; set; }
        public string TitleSecond { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int ClientCount { get; set; }

    }
}
