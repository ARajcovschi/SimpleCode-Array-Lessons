using System;

namespace Method_Test
{
    class Program
    {
        static string CharPrint(string Character, int Number)
        {
            Console.WriteLine("Line by your param's: ");
            string result="";
            for (int i = 0; i < Number; i++)
            {
                //Console.Write(Character+"\t");
                result += Character;
            }
            return result;
        }

        static void IndexOfElement(int [] ArrayName, int SearchValue)
        {
            for (int i = 0; i < ArrayName.Length; i++)
            {
                if (ArrayName[i] == SearchValue)
                {
                    Console.WriteLine("Index of your element is: " + i);
                    break;
                }
                
            }
        
        
        
        }
               
        static void Main(string[] args)
        {
            string a;
             Console.Write("Select Output Character: "+ "\n");
             a = Console.ReadLine();
             Console.Write("Select quantity: "+ "\n");
             int b = int.Parse(Console.ReadLine());

             string res = CharPrint(a, b);

            

            //int[] myArray = new int[] { 3, 8, 4, 6, 8, 9, 4546, 645654, 454, 78, 15 };


            //Console.WriteLine("Select Search Value: ");
            //int a = int.Parse(Console.ReadLine());

            //IndexOfElement(myArray, a);


        }
    }
}
