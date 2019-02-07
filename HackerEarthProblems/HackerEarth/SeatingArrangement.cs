using System;
//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/seating-arrangement-1/
namespace HackerEarthProblems
{
    public class SeatingArrangement
    {
        private int[,] getMatrix()
        {
            int[,] tMatrix = new int[18, 6];
            int k = 1;
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tMatrix[i, j] = k++;
                }
            }

            return tMatrix;
        }

        public void printSeats()
        {
            int[,] tMatrix = getMatrix();
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(tMatrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        public void GetOppositeSeat(int seatNo, ref int oppSeat, ref string seatType)
        {
            oppSeat = 19; ;
            seatType = "WS";
        }
    }
}
