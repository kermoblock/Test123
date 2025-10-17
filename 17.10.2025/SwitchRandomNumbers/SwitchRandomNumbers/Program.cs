namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuni kuueni");
            int cube = new Random().Next(1, 7);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Tuli number 1");
                    break;

                case 2:
                    Console.WriteLine("Tuli number 2");
                    break;

                case 3:
                    Console.WriteLine("Tuli number 3");
                    break;

                case 4:
                    Console.WriteLine("Tuli number 4");
                    break;

                case 5:
                    Console.WriteLine("Tuli number 5");
                    break;

                case 6:
                    Console.WriteLine("Tuli number 6");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;


            }

            //kõik kuus numbrit tuleb ära käsitleda switchiga
        }
    }
}
