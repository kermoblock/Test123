namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");

            int loop = 10;

            //int i on muutuja määratlemine ja selle väärtus on 0
            //i < loop ika kord võrdelb loop muutuja, et kas on suurem i-st
            //i++ liidab igakord ühe korra juurde ehk sama hea, kui i + 1
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Loop " + i);
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}
