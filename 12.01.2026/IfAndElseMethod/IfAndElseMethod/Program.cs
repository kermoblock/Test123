using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace IfAndElseMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello, World!");

            string choice = Console.ReadLine();

            if (choice == "Esimene")
            {
                Esimene();
            }
            else if (choice == "Teine")
            {
                Teine();
            }
            else if (choice == "Kolmas")
            {
                Kolmas();
            }
            else if (choice == "Neljas")
            {
                Neljas();
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        static void Esimene()
        {
             for (int i = 0; i < 3; i++)
             {
             Console.WriteLine("Tere");
             }
        }

        static void Teine() {
        int e = 0;

        do
        {
            Console.WriteLine("Hallo");

            e++;
            } while (e < 3);
        }

        static void Kolmas() {
        float result = 0;

        Console.WriteLine("Siesta esimene number");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Sisesta teine number");
        float num2 = float.Parse(Console.ReadLine());

        result = num1 + num2;
        Console.WriteLine("Vastus on " + result);
        }

        static void Neljas() {
        Console.WriteLine("Kui vana sa oled?");
        string vanus = Console.ReadLine();

        Console.WriteLine("Sa oled " + vanus);
            }
        }
    }
}








