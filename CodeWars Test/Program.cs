using System;

namespace CodeWars_Test
{

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Input Your Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Tascs.Descending.DescendingOrder(number)); 


        }
    }
}
