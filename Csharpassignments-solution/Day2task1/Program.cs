using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace Day2task1
{
    #region task1
    //Write a C# program to read the age of a candidate and determine whether it is eligible for casting his/her own vote

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //giving the user input
            Console.WriteLine("Enter the age of the candidate:");
            int age=int.Parse(Console.ReadLine());
            //giving the conition statement

            if (age >=18)
            {
                Console.WriteLine("the candidate is eligible for voting");

            }
            else
            {
                Console.WriteLine("sorry,the candidate is not eligible for voting");

            }
        }
    }
}
