namespace PWR_dotNER_Pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj seed:");
            int seed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ile przedmiotów wygenerować: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem.ToString());

            Console.WriteLine("Podaj pojemność plecaka: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(problem.Solver(capacity));
        }
    }
}
