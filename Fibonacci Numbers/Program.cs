using System;

namespace Fibonacci_Numbers
{
    class Program
    {
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
        static void Fibonacci(int Length = 50)
        {
            int[] FibArr = new int[Length];
            FibArr[0] = 0;
            FibArr[1] = 1;
            for (int i = 2; i < Length; i++)
            {
                FibArr[i] = FibArr[i - 2] + FibArr[i - 1];
            }
            for (int i = 0; i < FibArr.Length; i++)
            {
                Console.Write(FibArr[i] + "\t");
            }
        }

        static void FibonacciRec(int[]RecArray, int i = 2)
        {
            RecArray[i] = RecArray[i - 2] + RecArray[i - 1];
            if (i >= RecArray.Length-1) return ;
            i++;
            FibonacciRec(RecArray, i);
        }
        static int Factorial(int x)
        {
            
            if (x == 1) return 1;
            int result = x * Factorial(x - 1);
            return result;
            
        }


        static void PrintArray(int[] myArray)
        {
            Console.WriteLine();
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "\t");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Fibonacci(20);

            int[] RecArr= new int[20];
            RecArr[0] = 0;
            RecArr[1] = 1;
            FibonacciRec(RecArr);
            PrintArray(RecArr);

            Console.WriteLine($"Factorial of 5 = " + Factorial(5)); ;

        }
    }
}
