namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //peab saama sisestada numbrit ja muudab selle int admetüübiks

            //tuleb teha swtich, kus esimene case 10, teine case 20 ja kolmas case 30
            //kindlasti tuleb ka deafault lõppu tehas

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 10:
                    Console.WriteLine("Sisestasid numbri 10");
                    break;

                case 20:
                    Console.WriteLine("Sisestasid numbri 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid numbri 30");
                    break;

                default:
                    Console.WriteLine("Sisestasid vale numbri");
                    break;
            }
        }
    }
}
