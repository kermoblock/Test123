using System.Reflection;

namespace RectangleForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ristküliku kahe külje mõõdud");
            Console.WriteLine("Pikus");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Laius");
            double width = double.Parse(Console.ReadLine());

            for (int row = 1; row <= length; row++)
            {
                for (int col = 1; col <= width; col++)
                {
                    string mark;
                    if (row == col || row + col <= +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}


