namespace task6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the original string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the starting index (0-based): ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the length of the substring: ");
            int length = Convert.ToInt32(Console.ReadLine());

            string result = "";

            if (start < 0 || start >= input.Length || (start + length) > input.Length)
            {
                Console.WriteLine("Invalid start index or length.");
                return;
            }

            for (int i = start; i < start + length; i++)
            {
                result += input[i];
            }

            Console.WriteLine($"Extracted substring: {result}");
        }
    }
}
