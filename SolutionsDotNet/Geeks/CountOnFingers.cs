using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Solutions.Geeks
{
    public class CountOnFingers
    {
        public int GetFingerFromNumber(int number)
        {
            if (number % 8 == 1 )
                return 1;
            if (number % 8 == 2 || number % 8 == 0)
                return 2;
            if (number % 8 == 3 || number % 7 == 0)
                return 3;
            if (number % 8 == 4 || number % 8 == 6)
                return 4;
            if (number % 8 == 5)
                return 5;

            return 0;

        }
    }
}
