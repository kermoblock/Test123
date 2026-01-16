using System.ComponentModel.Design;

namespace Grupp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string input = Console.ReadLine();

            switch (input)
            {
                case "Esimene":
                    Esimene();
                    break;

                case "Teine":
                    Teine();
                    break;

                case "Kolmas":
                    Kolmas();
                    break;
            }

            static void Esimene()
            {
                Console.WriteLine("Loome tärnidest püramiidi: \n");
                Console.WriteLine("-----------------------------");
                Console.Write("\n\n");
                Console.WriteLine("Sisesta püramiidi kõrgus: ");

                int i, j, n;
                n = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i <= n; i++)
                {
                    for (j = 1; j <= n - i; j++)
                        Console.Write(" ");

                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");

                    Console.Write("\n");
                }
            }

            static void Teine()
            {
                Console.WriteLine("For Asteriks");

                int nr = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < nr; i++)
                {
                    
                    for (int j = 1; j < nr; j++)
                        Console.Write("*");

                    Console.WriteLine("*");
                }

                Console.WriteLine("Ruudu pindala on " + nr * nr);
                Console.WriteLine("Ruudu ümbermõõt on " + nr * 4);
            }


            static void Kolmas()
            {
                float result = 0;

                Console.WriteLine("Siesta muutuja A");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Sisesta muutuja p");
                float num2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Sisesta muutuja Q");
                float num3 = float.Parse(Console.ReadLine());

                result = num1 * (2 - num2) + 2 + num3;
                Console.WriteLine("Vastus on " + result);


                }
            }

    }
}
