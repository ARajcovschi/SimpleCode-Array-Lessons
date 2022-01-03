using System;

namespace Array_Resize_Method
{
    class Program
    {

        static void Resize(ref int[] NewArray, int Length)
        {
             NewArray = new int[Length];
        }

        static void ChangeArrElem(ref int[] Arr, int index, int Value)
        {
            Arr[index] = Value;
        }

        static void ChangeFirstElem(ref int[] Arr, int Value)
        {
            Arr[0] = Value;
        }

        static void ChangeLastElem(ref int[] Arr, int Value)
        {
            Arr[(Arr.Length-1)] = Value;
        }



        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            Console.WriteLine("Default Array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
            Console.Write(myArray[i]+"\t");

            }

            Console.Write("\n" + "input new array length: " + "\t");
            int a = int.Parse(Console.ReadLine());
            
            Resize(ref myArray, a);
            
            Console.Write("\n"+"Input index of changed element: "+"\t");
            int index = int.Parse(Console.ReadLine());

            Console.Write("\n"+"Input Value of changed element: "+"\t");
            int Value = int.Parse(Console.ReadLine());


            ChangeArrElem(ref myArray, index, Value);


            Console.Write("\n"+"Input changed Value of last element: "+"\t");
            int lastValue = int.Parse(Console.ReadLine());
            ChangeLastElem(ref myArray, lastValue);

            Console.WriteLine("Your Modified Array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "\t");

            }

        }
    }
}
