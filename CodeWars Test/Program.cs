using System;
using CodeWars_Test.Sorting;

namespace CodeWars_Test
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input Your Number: ");
            int number = int.Parse(Console.ReadLine());

            var descSortBubble = new DescendingBubbleSorting();
            Console.WriteLine(descSortBubble.DescendingOrder(number));

            var descSortShake = new DescendingShakingSorting();
            Console.WriteLine(descSortShake.ShakerSort(number));


        }
    }
}
