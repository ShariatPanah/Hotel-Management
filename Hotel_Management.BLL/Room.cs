using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    public class Room
    {
        public int RoomNo { get; set; }
        public int RoomCapacity { get; set; }
        public long RoomPrice { get; set; }
        public string RoomStatus { get; set; }
    }
}
