namespace MaaKalukaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //meil on münt, mille diameeter on 25.75mm
            //arvutada välja maa ümbermõõt ja mitu münti
            //mahub järjestiku ümber maa
            //arvutades tohib kasutada ainult mündi diameetrit ja maa raadiust

            //maa ümbermõõt:
            long maaraadius = 6371000000;
            Console.WriteLine("Maa ümbermõõt on " + 2 * Math.PI * maaraadius + " millimeetrit");

            //mitu münti mahub:
            double mündidiameeter = 25.75;
            double mündid = maaraadius / mündidiameeter;
            Console.WriteLine("Maa ümber mahub {0:0} münti", mündid);
        }
    }
}
