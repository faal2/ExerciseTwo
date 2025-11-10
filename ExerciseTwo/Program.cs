using System;

namespace ExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Priser för biobiljetter beroende på ålder
            const int youthPrice = 80;
            const int seniorPrice = 90;
            const int standardPrice = 120;

            // Åldersgränser för prisklasser
            const int youthAgeLimit = 20;
            const int seniorAgeLimit = 64;

            Console.Write("""
            Välkommen till huvudmenyn.
            Här har du följande handlingar du kan utföra. Du interagerar genom att skriva in siffran till det alternativ du vill göra:

            0. För att avsluta programmet.
            1. Se priserna för biobiljetter.
            2. Beräkna totalpris för biobiljetter.
            3. Repeterad text (10 gånger). 
            4. Tredje ordet från en text. 

            Skriv en siffra:  
            """);

            if (!int.TryParse(Console.ReadLine(), out int userNumber))
            {
                Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
            }
            else 
            {
                switch (userNumber)
                {
                    case 0:
                        Console.WriteLine("Du har avslutat programmet");
                        break;
                    case 1:
                        Console.WriteLine("Priserna skiljer beroende på ålder. Ange ålder för att se priser.\nSkriv en ålder: ");
                        if (!int.TryParse(Console.ReadLine(), out int givenAge)) 
                        {
                            Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
                            break;
                        }
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    default:
                        Console.WriteLine("Felaktig inskrivning. Du har angett ett otillgängligt nummer.");
                        break;
                }
            }
        }
    }
}
