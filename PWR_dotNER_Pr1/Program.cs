namespace PWR_dotNER_Pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seed, n, capacity;
            Console.WriteLine("Podaj seed:");
            seed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ile przedmiotów wygenerować: ");
            n = Convert.ToInt32(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem.ToString());

            Console.WriteLine("Podaj pojemność plecaka: ");
            capacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(problem.Solver(capacity));

        }
    }
}
