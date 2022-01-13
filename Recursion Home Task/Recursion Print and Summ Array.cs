using System;

namespace Recursion_Home_Task
{
    class ArrayRecursion
    {
        static void ArrayPrint(ref int[] myArray, int i = 0)
        {
            Console.Write(myArray[i] + "\t");
            if (i >= myArray.Length - 1 )
            {
                Console.WriteLine();
                return;
            }
            i++;
            ArrayPrint(ref myArray, i);
        }

        static void ArrayElementSum(ref int[] myArray, int i = 0, int result = 0)
        {
            result += myArray[i];
            if (i >= myArray.Length - 1)
            {
                Console.WriteLine("Array elements sum is: " + result);
                return;
            }

            i++;

            ArrayElementSum(ref myArray, i, result);
        }

        static void NumberElementsSum(string number,int i=0, int result=0)
        {
            char[] newArrayChars = number.ToCharArray();
            string elem = newArrayChars[i].ToString();
            int value = int.Parse(elem);
            result += value;
            if (i>=newArrayChars.Length-1)
            {
                Console.WriteLine("Number Elements sum is: "+result);
                return;
            }
            i++;

            NumberElementsSum(number, i, result);
            
        }

        static void Main(string[] args)
        {
            int[] newArray = { 1, 2, 3, 4, 5 };
            string newNumber = "561";

            char[] newArrayChars = newNumber.ToCharArray();


            NumberElementsSum(newNumber);
            ArrayPrint(ref newArray);
            ArrayElementSum(ref newArray);

        }
    }
}
