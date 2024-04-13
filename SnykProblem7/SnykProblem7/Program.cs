namespace SnykProblem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
            n = int.Parse(Console.ReadLine());

            }
                
            catch(FormatException e)
            {
                Console.WriteLine("Please enter a number");
            }
            Staircase(n);
        }
        static void Staircase(int n)
        {
            for(int i = 0; i <=n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        static void Staircase2(int n)
        {
            Console.WriteLine();
            int k = n;
            for(int i = 0; i <= n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<i;j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                k--;
            }
        }
    }
}
