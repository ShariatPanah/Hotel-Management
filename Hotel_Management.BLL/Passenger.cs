using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    public class Passenger
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public long NationCode { get; set; }
        public string FatherName { get; set; }
        public string BirthDate { get; set; }
        public int RoomNo { get; set; }
        public int StayingNights { get; set; }
        public long Amount { get; set; }
        public string SubmitTime { get; set; }
        public string DefrayTime { get; set; }
    }
}
