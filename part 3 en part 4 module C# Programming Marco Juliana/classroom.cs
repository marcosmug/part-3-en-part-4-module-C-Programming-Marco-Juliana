using System;

class room =
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_3_en_part_4_module_C__Programming
{
    public class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfSeats)
        {
            code = classCode;
            seats = numberOfSeats;
        }
    }
}