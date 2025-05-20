using System.Threading;

namespace Day2task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to read roll no, name and marks of three subjects and calculate the total, percentage and division
            // giving name,rollno,and each subject marks as user input
            Console.WriteLine("Enter the Name:");
            string Name=Console.ReadLine();
            Console.WriteLine("Enter the rollno:");
            string rollno=Console.ReadLine();
            Console.WriteLine("Enter the mark for Tamil:");
            int Tamil=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark for English:");
            int English=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark for the Malayalam:");
            int Malayalam=int.Parse(Console.ReadLine());
            //add the 3subject marks and taking total marks
            int totalmarks=Tamil+English+Malayalam;
            //with total marks calculating percentage
            float Percentage = (totalmarks * 100) / 300;
            //printing name,rollno,totalmarks,percentage
            Console.WriteLine("name:{0}", Name);
            Console.WriteLine("Rollno:{0}", rollno);
            Console.WriteLine("totalmarks:{0}", totalmarks);
            Console.WriteLine("Percentage:{0}", Percentage);

            //with the percentage give the condition to find the grade 

            if (Percentage >= 90 && Percentage <= 100)
            {
                Console.WriteLine("Grade A");

            }
            else if (Percentage >= 80 && Percentage < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (Percentage >= 70 && Percentage < 80)
            {
                Console.WriteLine("Grade C");
            }
            else if (Percentage >= 60 && Percentage < 70)
            {
                Console.WriteLine("Grade D");
            }
            else if(Percentage >=40 && Percentage < 60)
            {
                Console.WriteLine("Grade E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
          
        }
    }
}
