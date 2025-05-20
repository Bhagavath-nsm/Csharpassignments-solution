using System.Security.Principal;

namespace Day2task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Triangle");
            Console.WriteLine("4.Circle");
            Console.WriteLine("Enter the shape:");
            int shape=int.Parse(Console.ReadLine());
            if (shape == 1)
            {
                Console.WriteLine("Enter the side of the square");
                int side = int.Parse(Console.ReadLine());
                int Area = side * side;
                Console.WriteLine("Area of the Square={0}",Area);
            }
            else if (shape == 2)
            {
                Console.WriteLine("Enter the length:");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width:");
                int Width=int.Parse(Console.ReadLine());
                int Area = length * Width;
                Console.WriteLine("Area of the Rectangle:{0}", Area);
            }
            else if (shape == 3)
            {
                Console.WriteLine("Enter the base:");
                int Base= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height:");
                int height= int.Parse(Console.ReadLine());
                float Area = 0.5f * Base * height;
                Console.WriteLine("Area of the  Triangle:{0}", Area);

            }
            else if (shape == 4)
            {
                Console.WriteLine("Enter the radius:");
                int radius= int.Parse(Console.ReadLine());
                double area= (3.14159265359) * radius*radius;
                Console.WriteLine("Area of the Circle:{0}",area);
            }
            else
            {
                Console.WriteLine("Enter the valid option");
            }

        }
    }
}
