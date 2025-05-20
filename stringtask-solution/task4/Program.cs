namespace task4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(ch))
                {
                    digitCount++;
                }
                else if (!char.IsWhiteSpace(ch))
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine($"\nTotal Alphabets: {alphabetCount}");
            Console.WriteLine($"Total Digits: {digitCount}");
            Console.WriteLine($"Total Special Characters: {specialCharCount}");
        }

    }
}