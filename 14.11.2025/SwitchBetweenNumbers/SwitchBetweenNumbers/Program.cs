namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esimese koondtulemuse puhul on number vahemikus
            //0 kuni 100,
            //teise puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasutada switchi
            Console.WriteLine("Hello, World!");

            int.TryParse(Console.ReadLine(), out int number);

            switch(number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Number on vahemikus 1 kuni 100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("Number on vahemikus 101 kuni 200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("Number on vahemikus 201 kuni 300");
                    break;

                default:
                    Console.WriteLine("Sisestasid vale arvu");
                    break;
            }
        }
    }
}
