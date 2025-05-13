using System.ComponentModel.Design;

namespace Day1task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the value of y:");
            int y = int.Parse(Console.ReadLine());
            if (y >= -5 & y <= 5)
            {

                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Please give a valid input");
            }
                


        }
    }
}
