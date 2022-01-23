using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Welcome. In this kata, you are asked to square every digit of a number and concatenate them.
//For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
//Note: The function accepts an integer and returns an integer

namespace CodeWars_Test.Tasks
{
    class SquareDigits
    {
        public int SquareDigit(int number)
        {
            int[] newArr = Helper.NumToArray(number);
            int[] squareArr = new int[newArr.Length];
            int index = newArr.Length - 1;
            for (int i = 0; i < newArr.Length; i++)
            {
                squareArr[index] = newArr[i] * newArr[i];
                index--;
            }

            string result = string.Join("", squareArr);
            int solution = int.Parse(result);
            return solution;
        }
    }
}
