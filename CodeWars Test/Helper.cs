using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Test
{
    class Helper
    {
        public static int[] NumToArray(int number)
        {

            List<int> myNumbers = new();
            for (int i = 0; i < int.MaxValue; i++)
            {
                int digit = number % 10;
                myNumbers.Add(digit);
                number /= 10;
                if (number < 10)
                {
                    myNumbers.Add(number);
                    break;
                }
            }
            int[] arrInt = new int[myNumbers.Count];
            myNumbers.CopyTo(arrInt);

            return arrInt;
        }

        public static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
    }
}
