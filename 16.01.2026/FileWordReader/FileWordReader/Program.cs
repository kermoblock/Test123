namespace FileWordReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luuletus");

            FileWordReader();
        }

        static void FileWordReader()
        {
            string Line;

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/luuletus.txt"))
                {
                    int cnt = 0; //rea muutuja
                    while (sr.EndOfStream == false)
                    {
                        ++cnt;  //rea nr suurendamine 1 ühiku võrra
                        Line = sr.ReadLine();  //teksti lugemine txt failist
                        int pikkus = Line.Length;  //sõna lugemine, kui see sõna pikkusena
                        Console.WriteLine(cnt + " " + Line + " " + pikkus);
                    }
                    sr.Close();  //faili lugemise lõpetamine
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Faili ei saa lugeda");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
