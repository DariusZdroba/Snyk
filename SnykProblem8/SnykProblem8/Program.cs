namespace SnykProblem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s = Console.ReadLine();

            if(s != null)
            {
                Encrypt(s);
            }
        }

        static void Encrypt(string s)
        {
            s = s.Replace(" ", "");

            int floor = (int)Math.Floor(Math.Sqrt(s.Length));
            int ceil = (int)Math.Ceiling(Math.Sqrt(s.Length));
            
            int iterator = 0;

            for(int i=0; i < floor; i++)
            {
                for(int j=0; j < ceil && iterator < s.Length; j++)
                {
                    Console.Write(s[iterator]);
                    iterator++;
                }
                Console.WriteLine();
            }
        }
    }
}
