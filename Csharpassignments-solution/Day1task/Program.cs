namespace Day1task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("enter the number:");
            string number=Console.ReadLine();
            Console.Write("enter the width of the triangle:");
            int width = int.Parse(Console.ReadLine());
            int i = 1;
            for (i = 1; i <= width; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(number);
                    
                }
                Console.WriteLine("\n");

            }






        }
    }
}
