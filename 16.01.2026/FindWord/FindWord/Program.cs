using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("Kasuta formaati: s--a kus - tähistab tundmatud tähte");

            string choice = Console.ReadLine();

            WordFinder(choice);
        }

        private static void WordFinder(string choice)
        {
            Regex regularExp = new Regex(@"\b" + choice.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/lemmad.txt", Encoding.Default))
                {
                    int Linenumber = 0;

                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();

                        if (line.Length == choice.Length)
                        {
                            MatchCollection matchcollection = regularExp.Matches(line);

                            if (matchcollection.Count > 0)
                            {
                                Linenumber++;
                                Console.WriteLine(Linenumber + " " + line);
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ei ole olemas sellise pikkusega sõna");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
