namespace Day1task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance:");
            int distance=int.Parse(Console.ReadLine());

            Console.Write("Enter the time:");
            int time = int.Parse(Console.ReadLine());
            int speedkm = distance / time;
            double speedmiles = distance * 0.621371;
            Console.WriteLine("speed:{0} km/hr",speedkm);
            Console.WriteLine("speed:{0} mph", speedmiles);

           
           
        }
    }
}
