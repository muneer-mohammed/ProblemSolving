using System;
using NUnit.Framework;
using Projects;

namespace MyProjects
{
    [TestFixture]
    public class SeatingArrangementTest
    {
        [Test]
        [TestCase(18, 19, "WS")]
        //[TestCase(40, 45, "AS")]
        public void SeatingTest_WS(int seatNo, int expectedSeat, string expectedSeatTye)
        {
            SeatingArrangement arrangmnt = new SeatingArrangement();
            int oppSeat = 0;
            string seatType = "";
            arrangmnt.GetOppositeSeat(seatNo, ref oppSeat, ref seatType);

            Assert.AreEqual(expectedSeat, oppSeat);
            Assert.AreEqual(expectedSeatTye, seatType);
        }
    }
}
