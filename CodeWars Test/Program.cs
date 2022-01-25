using System;
using CodeWars_Test.Sorting;
using CodeWars_Test.Tasks;

namespace CodeWars_Test
{

    class Program
    {

        static void Main(string[] args)
        {
            // Console.Write("Input Your Number: ");
            // int number = int.Parse(Console.ReadLine());

            //var descSortBubble = new DescendingBubbleSorting();
            //Console.WriteLine(descSortBubble.DescendingOrder(number));

            //  var descSortShake = new DescendingShakingSorting();
            //  Console.WriteLine(descSortShake.ShakerSort(number));

            //  var square = new SquareDigits();
            // Console.WriteLine(square.SquareDigit(number));

            string[] name = new string[] { "Alex", "Jacob", "Mark", "Max" };
            Console.WriteLine(WhoLikesIt.Likes(name));
        }
    }
}
