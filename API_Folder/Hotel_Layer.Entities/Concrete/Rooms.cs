using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Entities.Concrete
{
    public class Rooms
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomImage { get; set; }
        public int Price { get; set; }
        public string Wifi { get; set; }
        public string RoomTitle {  get; set; }
        public string BedCount {  get; set; }
        public string BathCount { get; set; }
        public string Description {  get; set; }    

    }
}
