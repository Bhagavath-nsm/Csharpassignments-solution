namespace Day2task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Maths:");
            int Maths=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Phy:");
            int Phy=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Chem:");
            int Chem=int.Parse(Console.ReadLine());

            int Total = Maths + Phy + Chem;
            int TwoSubTotal = Phy + Chem;
            Console.WriteLine("Total in all 3subjects:{0}", Total);
            if (Maths >=65 && Phy >=55 && Chem >=50 && Total>=180)
            {
                Console.WriteLine("Eligible for the Admission");
            }
            else if(Maths >=65 && TwoSubTotal >=140)
            {
                Console.WriteLine("Eligible for the Admission");

            }
            else
            {
                Console.WriteLine("Not Eligible for the Admission");
            }

        }
    }
}
