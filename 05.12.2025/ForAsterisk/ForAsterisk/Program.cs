namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asteriks");

            int nr = Convert.ToInt32(Console.ReadLine());

            //tuleb kasutada for loopi
            //siestan ridade arvu ja tuleb vastav arv konsooli
            //peab näitama tärne

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
