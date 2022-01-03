using System;

namespace Array_Resize_Method
{
    class Program
{

    static void Resize(ref int[] Array, int Length)
    {
        int[] NewArray = new int[Length];
        for (int i = 0; i < Array.Length && i < NewArray.Length; i++)
        {
            NewArray[i] = Array[i];
        }

        Array = NewArray;
    }

    static void Insert(ref int[] Arr, int index, int Value)
    {
        int[] NewArray = new int[Arr.Length + 1];
        NewArray[index] = Value;

        for (int i = 0; i < index; i++)
            NewArray[i] = Arr[i];
        for (int i = index; i < Arr.Length; i++)
            NewArray[i + 1] = Arr[i];
        Arr = NewArray;

    }

    static void ChangeFirstElem(ref int[] Arr, int Value)
    {
        Insert(ref Arr, 0, Value);
    }

    static void ChangeLastElem(ref int[] Arr, int Value)
    {
        Insert(ref Arr, (Arr.Length), Value);
    }



    static void Main(string[] args)
    {
        int[] myArray = { 1, 6, 5, 8, 7 };
        Console.WriteLine("Default Array: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + "\t");

        }

        // Console.Write("\n" + "input new array length: " + "\t");
        // int a = int.Parse(Console.ReadLine());

        //Resize(ref myArray, a);


        Console.Write("\n" + "Input Value of first element: " + "\t");
        int FirstValue = int.Parse(Console.ReadLine());
        ChangeFirstElem(ref myArray, FirstValue);

        Console.Write("\n" + "Input Value of last element: " + "\t");
        int LastValue = int.Parse(Console.ReadLine());
        ChangeLastElem(ref myArray, LastValue);

        Console.Write("\n" + "Input index of changed element: " + "\t");
        int index = int.Parse(Console.ReadLine());
        Console.Write("\n" + "Input Value of changed element: " + "\t");
        int Value = int.Parse(Console.ReadLine());
        Insert(ref myArray, index, Value);


        Console.WriteLine("Your Modified Array: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + "\t");

        }

    }
}
}

