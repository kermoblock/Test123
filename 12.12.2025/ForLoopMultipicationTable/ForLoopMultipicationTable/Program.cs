namespace ForLoopMultipicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int j, i, n;

            Console.WriteLine("Siesta tabelisse number, millest soovid alustada");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Korrutustabel ühest kuni {0}", n);

            for (i = 0; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <=  n - i)
                    {
                        Console.Write("{0}x{1} = {2} ", j, i, i * j);
                    }
                    else
                    {
                        Console.Write("{0}x{1} = {2} ", j, i, i * j);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
