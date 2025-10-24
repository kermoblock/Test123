namespace SwitchWeekDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb kasutada switch lauset
            //kui nädalapäev on esmaspäev , siis prinditakse "Tere esmaspäev!"
            //peate kasutama DayOfWeek enumeratsiooni

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Tere Esmaspäev!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Teisipäev");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Kolmapäev");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Neljapäev");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Reede");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Laupäev");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Pühapäev");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
