using System.Drawing;

namespace Day2task2
{
    internal class Program
    {
        //Write a C# program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        static void Main(string[] args)
        {
            //giving user input for x and y 
            Console.WriteLine("Enter the value of x:");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            int y=int.Parse(Console.ReadLine());
            //if condition for 1st quadrant
            if (x > 0 && y > 0)
            {
                Console.WriteLine("hence it is in 1st Quadrant");
            }
            //condition for 2nd quadrant
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("hence it is in 2nd Quadrant");
            }
            //condition for 3rd quadrant
            else if (x <0 && y < 0)
            {
                Console.WriteLine("hence it is in 3rd Quadrant");

            }
            //condition for 4th quadrant
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("hence it is in 4th Quadrant");
            }





        }
    }
}
