namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number 1,2 või 3");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Beep();
                    break;
                case "2":
                    Console.Beep();
                    Console.Beep();
                    break;
                case "3":
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
