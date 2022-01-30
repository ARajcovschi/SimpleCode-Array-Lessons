using System;
using CodeWars_Test.Sorting;
using CodeWars_Test.Tasks;


namespace CodeWars_Test
{

    class Program : ISortTypeSelect
    {
        public void SelectSort()
        {
            Console.WriteLine("Choose Type of Sorting \n 1 - Bubble Sorting \n 2 - Shaker Sorting");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                DescendingBubbleSorting.DescendingOrder(Helper.GetNumber());
            if (choice == 2)
                DescendingShakingSorting.ShakerSort(Helper.GetNumber());
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.SelectSort();
            ;
            //var descSortBubble = new DescendingBubbleSorting();
            //Console.WriteLine(descSortBubble.DescendingOrder(number));

            //  var descSortShake = new DescendingShakingSorting();
            //  Console.WriteLine(descSortShake.ShakerSort(number));

            //  var square = new SquareDigits();
            // Console.WriteLine(square.SquareDigit(number));

            //string[] name = new string[] { "Alex", "Jacob", "Mark", "Max" };
            //Console.WriteLine(WhoLikesIt.Likes(name));
        }

       
    }
}



