using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars_Test.Sorting;

namespace CodeWars_Test.Sorting
{
    class DescendingBubbleSorting:ISorting
    {
       
        public int Sort(int num)
        {
            int[] NumberArr = Helper.NumToArray(num);

            for (int i = 0; i < NumberArr.Length; i++)
            {
                for (int j = i + 1; j < NumberArr.Length; j++)
                    if (NumberArr[i] < NumberArr[j])
                        Helper.Swap(ref NumberArr[j], ref NumberArr[i]);
            }
            string result = string.Join("", NumberArr);
            int sequence = int.Parse(result);
            Console.WriteLine("Your Bubble Arranged Number is: " + sequence);
            return sequence;
        }
    }
}
