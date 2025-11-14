using System.Threading.Channels;

namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          float result = 0;

            Console.WriteLine("Siesta esimene number");
            //loeme kasutaja sisendit ja teisendame selle float tüübiks
            float num1 = float.Parse(Console.ReadLine());

            //konsool kirjutab, et sisesta teine number ja teisendame selle float tüübiks
            Console.WriteLine("Sisesta teine number");
            float num2 = float.Parse(Console.ReadLine());

            //konsool kirjutab kasutajale, et vali tehe: +, -, *, /
            Console.WriteLine("Saab kasutada +, -, *, /");
            string op = Console.ReadLine();

            //teeme switch lausega tehte valiku
            switch (op) {

                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Nulliga ei tohi jagada");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result = " + result);
                    }
                    break;
            }
        }
    }
}
