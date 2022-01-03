using System;

namespace Array_Resize_Method
{
    class Program
    {

        static void Resize(ref int[] NewArray, int Length)
        {
             NewArray = new int[Length];
        
        }



        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
            Console.Write(myArray[i]+"\t");

            }

            Console.Write("\n" + "Input New array Length: " + "\t");
                int a = int.Parse(Console.ReadLine());
            Resize(ref myArray, a);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "\t");

            }

        }
    }
}
