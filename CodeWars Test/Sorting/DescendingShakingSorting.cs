using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Test.Sorting
{
    class DescendingShakingSorting
    {
        public static int ShakerSort(int number)
        {
            int[] NewArrayForSort = Helper.NumToArray(number);

            if (number < 10) return number;

            int left = 0;
            int right = NewArrayForSort.Length - 1;
            while (left <= right)
            {
                for (int i = right; i > left; i--)
                {
                    if (NewArrayForSort[i - 1] < NewArrayForSort[i])
                    {
                        Helper.Swap(ref NewArrayForSort[i - 1], ref NewArrayForSort[i]);
                    }
                }
                left++;
                for (int i = left; i < right; i++)
                {
                    if (NewArrayForSort[i] < NewArrayForSort[i + 1])
                    {
                        Helper.Swap(ref NewArrayForSort[i], ref NewArrayForSort[i + 1]);
                    }
                }
                right--;
            }
            string result = string.Join("", NewArrayForSort);
            int sequence = int.Parse(result);

            return sequence;
        }

    }
}

