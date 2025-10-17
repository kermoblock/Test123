namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vokaal ja vajuta enter");
            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Console.WriteLine("vokaal a");
                        break;

                case "e":
                    Console.WriteLine("vokaal e");
                    break;

                case "i":
                    Console.WriteLine("vokaal i");
                    break;

                default:
                    Console.WriteLine("Muu täht");
                    break;

            }

        }
    }
}
