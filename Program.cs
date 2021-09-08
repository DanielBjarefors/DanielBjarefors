using System;

namespace ålder_för_övningskörning
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 0;
            Console.WriteLine("What`s your age?");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out age) || age <= 0 || age > 100)
            {
                Console.WriteLine("Dude.. you had one job, your age... Try again...");
                input = Console.ReadLine();
            }

            if (age >= 24)
            {
                Console.WriteLine(" You can övningsköra everything!! ");
                Console.ReadKey();
            }
            else if (age >= 21)
            {
                Console.WriteLine(" You can övningsköra everything except \"Tung motorcykel med obegränsad effekt\" !! ");
                Console.ReadKey();
            }

            else if (age >= 18)
            {
                Console.WriteLine(" You can övningsköra: \r\n" +
                    " Personbil med tungt släp och lastbil med tungt släp \r\n" +
                    " Tung motorcykel  \r\n" +
                    " Personbil\r\n" +
                    " Lätt motorcykel\r\n" +
                    " Moped klass I (EU-moped)");
                Console.ReadKey();
            }

            else if (age >= 17)
            {
                Console.WriteLine(" You can övningsköra: \r\n" +
                    " Tung motorcykel  \r\n" +
                    " Personbil\r\n" +
                    " Lätt motorcykel\r\n" +
                    " Moped klass I (EU-moped)");
                Console.ReadKey();
            }
            else if (age >= 16)
            {
                Console.WriteLine(" You can övningsköra:\r\n" +
                     " Personbil\r\n" +
                     " Lätt motorcykel\r\n" +
                     " Moped klass I (EU-moped)");
                Console.ReadKey();
            }
            else if (age >= 15)
            {
                Console.WriteLine(" You can övningsköra:\r\n" +
                       " Lätt motorcykel\r\n" +
                       " Moped klass I (EU-moped)");
                Console.ReadKey();
            }
            else if (age >= 14)
            {
                Console.WriteLine(" You can övningsköra:\r\n" +
                      " Moped klass I (EU-moped)");
                Console.ReadKey();

            }
            else if (age < 14)
            {
                Console.WriteLine("Ingen övningskörning för dig. Krypa, gå, springa, cyckla! ");
                Console.ReadKey();

            }

        }
    }
}
