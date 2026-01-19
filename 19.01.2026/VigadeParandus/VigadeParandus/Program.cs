using System.Drawing;

namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vigade parandus");

            Console.WriteLine("Vajuta numbrit");
            Console.WriteLine("1. Tagurpidi püramiid");
            Console.WriteLine("2. Ristküülik");
            Console.WriteLine("3. Püramiid");

            string input = Console.ReadLine();
            //Puhastab konsooli eelnevast tekstist
            Console.Clear();

            switch (input)
            {
                //Meetodi välja kutsumine
                case "1":
                    UpsidedownPyramiid();
                    break;

                    case "2":
                        Rectangle();
                        break;

                    case "3":
                        Pyramiid();
                        break;

                default:
                    Console.WriteLine("Valik puudub");
                    break;
            }
        }

        static void UpsidedownPyramiid()
        {
            Console.WriteLine("Sisesta kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n - 0; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void Rectangle()
        {
            Console.WriteLine("Siesta pikkus");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Siesta laius");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }

            int area = row * width;
            int around = 2 * (row + width);

            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + around);
        }

        static void Pyramiid()
        {
            Console.WriteLine("Siesta Kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n;  i++)
            {
                for (j = 1; j <= n - i;  j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1;  j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

        }
    }
}
