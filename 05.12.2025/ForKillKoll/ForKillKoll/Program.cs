namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int arv = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arv; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Kill-Koll");
                }

                for (int k = 0; k < 1; k++)
                {
                    Console.WriteLine("Killadi-Koll");
                }
            }
            Console.WriteLine("Kill-Koll");
        }
    }
}
