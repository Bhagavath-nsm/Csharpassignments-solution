namespace stringtask2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //get input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Characters in reverse order:");
            //reverse the string
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
        }

    }
}

