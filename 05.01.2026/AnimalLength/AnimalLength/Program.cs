using System.Threading.Channels;

namespace AnimalLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //1. masiivi tegemine
            string[] animalName = { "Koer", "Kass", "Jänes", "Sipelgas", "Lendorav" };

            //2. programm peab aru saama, et sõna pikkusest
            int longerName = animalName[0].Length;
            string longerNameString = animalName[0];

            //3. for loop tuleb teha, et saaks nimede pikkust omavahel võrrelda
            //for loopi sees tuleks kasutada if-i
            for (int i = 0; i < animalName.Length; i++)
            {
                if (longerName < animalName[i].Length)
                {
                    longerName = animalName[i].Length;
                    longerNameString = animalName[i];
                }

                int animalLength = AnimalLength(animalName[i]);
                Console.WriteLine(animalName[i] + " = ");
                Console.WriteLine(animalLength);
                Console.WriteLine();
            }
            Console.WriteLine("Pikim nimi oli {0} ja mille nime pikkus oli: {1}", longerNameString, longerName);
        }

        static int AnimalLength(string animalName)
        {
            return animalName.Length;
        }
    }
}

