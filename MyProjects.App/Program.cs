using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects;

namespace MyProjects.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SeatingTest_WS(18, 19, "WS");
            Console.ReadLine();
        }

        public static void SeatingTest_WS(int seatNo, int expectedSeat, string expectedSeatTye)
        {
            SeatingArrangement arrangmnt = new SeatingArrangement();
            int oppSeat = 0;
            string seatType = "";
            arrangmnt.printSeats();
           // arrangmnt.GetOppositeSeat(seatNo, ref oppSeat, ref seatType);
        }
    }
}
