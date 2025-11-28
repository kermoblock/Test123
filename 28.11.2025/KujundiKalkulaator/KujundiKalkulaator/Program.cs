namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int raadius = 3;

            Console.WriteLine("Ruudu pindala on " + (raadius * 2) * (raadius * 2));
            Console.WriteLine("Ruudu ümbermõõt on " + (raadius * 2) * 4);

            //arvutada ringi pindala ja ümbermõõt

            Console.WriteLine("Ringi Ümbermõõt on " + 2 * Math.PI * raadius);
            Console.WriteLine("Ringi Pindala on " + Math.PI * (raadius * raadius));
        }
    }
}
