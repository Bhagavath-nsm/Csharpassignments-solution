namespace Day2task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter the option:");
            int option=int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter Firstnum value:");
                int Firstnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Secnum value:");
                int Secnum = int.Parse(Console.ReadLine());
                float Addition = Firstnum + Secnum;
                Console.WriteLine("Result:{0}", Addition);
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter Firstnum value:");
                int Firstnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Secnum value:");
                int Secnum = int.Parse(Console.ReadLine());
                float Subraction = Firstnum - Secnum;
                Console.WriteLine("Result:{0}", Subraction);
            }
            else if (option == 3)
            {
                Console.WriteLine("Enter Firstnum value:");
                int Firstnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Secnum value:");
                int Secnum = int.Parse(Console.ReadLine());
                float Multiplication = Firstnum * Secnum;
                Console.WriteLine("Result:{0}", Multiplication);
            }
            else if (option == 4)
            {
                Console.WriteLine("Enter Firstnum value:");
                int Firstnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Secnum value:");
                int Secnum = int.Parse(Console.ReadLine());
                float Division = Firstnum / Secnum;
                Console.WriteLine("Result:{0}", Division);
            }
            else
            {
                Console.WriteLine("please enter the valid input");
            }
            }
    }
}
