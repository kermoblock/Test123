namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //sisestad konsooli väärtuse
            //loeb sisestatud väärtuse stringina
            //tuleb kasutada switchi
            //esimeses cases on väärtused "Intro to C#", "Variables",
            //Data Types ja väärtuseks on Basic
            //Teises cases on väärtused "OOP", "Classes",
            //"Objects" ja vastuseks Intermediate
            //Kolmandas cases on väärtused "Asynchronous programming", "LINQ",
            //"Delegates" ja vastuseks Advanced

            string topic, category;

            topic = Console.ReadLine();

            switch (topic)

            {
                case "Intro to C#":
                case "Variables":
                case "Data Types":
                    category = "Basic";
                    break;

                case "OOP":
                case "Classes":
                case "Objects":
                    category = "Intermediate";
                    break;

                case "Asychronous prorgramming":
                case "LINQ":
                case "Delegates":
                    category = "Advanced";
                    break;

                default:
                    category = "Unknown";
                        break;
            }
            Console.WriteLine("Category is " + category);
        }
    }
}
