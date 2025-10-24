namespace MultipleSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string topic, category;

            topic = Console.ReadLine();

            switch (topic)
            {
                case "Intro to c#":
                case "Variables":
                case "Data Types":
                    category = "Basics";
                    break;

                case "Loops":
                case "If Statements":
                case "Jump Statements":
                    category = "Control Flow";
                    break;

                case "Class & Objects":
                case "Inheritance":
                case "Constructors":
                    category = "OOP-s Concept";
                    break;

                default:
                    category = "unknown";
                    break;
            }
            Console.WriteLine("Category is " + category);
        }
    }
}
