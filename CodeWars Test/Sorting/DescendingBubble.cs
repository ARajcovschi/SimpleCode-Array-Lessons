﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Test.Sorting
{
    class DescendingBubbleSorting
    {
        public int DescendingOrder(int num = 12345)
        {
            int[] NumberArr = Helper.NumToArray(num);

            int tmp;
            for (int i = 0; i < NumberArr.Length; i++)
            {
                for (int j = i + 1; j < NumberArr.Length; j++)
                    if (NumberArr[i] < NumberArr[j])
                    {
                        tmp = NumberArr[j];
                        NumberArr[j] = NumberArr[i];
                        NumberArr[i] = tmp;
                    }
            }
            string result = string.Join("", NumberArr);
            int sequence = int.Parse(result);

            return sequence;
        }
    }
}
