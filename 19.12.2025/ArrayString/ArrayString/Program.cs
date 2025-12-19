namespace ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Euroopa üks pealinnadest on ";
            Console.WriteLine("Tuple");
            var cities = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsingi");
            //Tuple all on viis erinevat väärtust ja sellepärast saab antud
            //juhul 5 item-t siestada
            Console.WriteLine(sentence + cities.Item5);
            Console.WriteLine("---------------------");

            //näide 2
            string[] city = { "Tallinn", "Pariis", "Rooma", "London", "Helsingi" }; 
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("---------------------");

            //näide 3
            Console.WriteLine(sentence + city[2]);
            Console.WriteLine("---------------------");

            //näide 4
            Random number = new Random();
            int randomnumber =number.Next(0, 4);
            Console.WriteLine(sentence + city[randomnumber]);

        }
    }
}
