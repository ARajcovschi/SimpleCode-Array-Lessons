using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Your task is to make a function that can take any non-negative integer as an argument
//and return it with its digits in descending order. Essentially,
//rearrange the digits to create the highest possible number.
namespace CodeWars_Test.Tascs
{
    public static class Descending
    {
        public static int DescendingOrder(int num = 12345)
        {
            string number = num.ToString();
            char[] elementsArr = number.ToCharArray();
            int[] NumberArr = Array.ConvertAll(elementsArr, c => (int)Char.GetNumericValue(c)); //альтернатива intArray[i] = int.Parse(nums[i]);
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
            int Sequence = int.Parse(result);

            return Sequence;
        }
    }




}
