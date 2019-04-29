using System;
using NUnit.Framework;
using Solutions.Geeks;
using Solutions.HackerEarth;

namespace Solutions.Tests
{
    [TestFixture]
    public class GeeksTest
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

        [Test]
        [TestCase(17, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        [TestCase(6, 4)]
        [TestCase(7, 3)]
        [TestCase(8, 2)]
        [TestCase(9, 1)]
        public void GetFingerFromNumber(int number, int expectedFinger)
        {
            CountOnFingers cntFinger = new CountOnFingers();
            int returnedFinger = cntFinger.GetFingerFromNumber(number);

            Assert.AreEqual(expectedFinger, returnedFinger);
        }

        [Test]
        [TestCase(true, "{[()]}")]
        [TestCase(false, "{[(])}")]
        [TestCase(false, "[(])")]
        [TestCase(false, "[)")]
        [TestCase(true, "{{[[(())]]}}")]
        [TestCase(false, "}][}}(}][))]")]
        [TestCase(true, "[](){()}")]
        [TestCase(true, "()")]
        [TestCase(true, "({}([][]))[]()")]
        [TestCase(false, "{)[](}]}]}))}(())(")]
        [TestCase(false, "([[)")]
        public void IsParenthesisBalanced(bool exptectedResult, string input)
        {
            IsParenthesisBalanced obj = new IsParenthesisBalanced();
            bool actualResult = obj.IsBalanced(input);

            Assert.AreEqual(exptectedResult, actualResult);
        }
    }
}