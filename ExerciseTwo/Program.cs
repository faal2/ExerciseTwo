using System;

namespace ExerciseTwo
{
    internal class Program
    {
        // Priser för biobiljetter beroende på ålder
        const int youthPrice = 80;
        const int seniorPrice = 90;
        const int standardPrice = 120;

        // Åldersgränser för prisklasser
        const int youthAgeLimit = 20;
        const int seniorAgeLimit = 64;
        static void Main(string[] args)
        {

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
                        else
                        {
                            int price = priceForAge(givenAge);
                            if (price == youthPrice)
                            {
                                Console.WriteLine($"Ungdomspris: {price}kr");
                                break;
                            } 
                            else
                            {
                                if (price == seniorPrice)
                                {
                                    Console.WriteLine($"Pensionärspris: {price}kr");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"Standardpris: {price}kr");
                                    break;
                                }
                            }
                        }
                    case 2:
                        int totalCost = 0;
                        Console.WriteLine("Hur många i sällskap har du?");
                        if (!int.TryParse(Console.ReadLine(), out int userCompanions))
                        {
                            Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
                            break;
                        }
                        else
                        {
                            if (userCompanions < 1)
                            {
                                Console.WriteLine("Du måste ha minst ett sällskap.");
                                break;
                            }
                            else {
                                Console.WriteLine("Nu ska du ange ålderna på sällskapet. En i taget. Siffran framför kommer visa vilken person detta gäller.");
                                for (int i = 1; i <= userCompanions; i++)
                                {
                                    Console.Write($"Ålder för person {i}: ");
                                    if (!int.TryParse(Console.ReadLine(), out int companionAge))
                                    {
                                        Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
                                        break;
                                    }
                                    else
                                    {
                                        int companionPrice = priceForAge(companionAge);
                                        totalCost += companionPrice;
                                    }
                                }
                                Console.WriteLine($"Totalkostnaden för biobiljetterna är: {totalCost}kr");
                                break;
                            }
                                
                        }
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
    public static int priceForAge(int age)
    {
        if (age < youthAgeLimit)
            return youthPrice;
        else if (age > seniorAgeLimit)

            return seniorPrice;

        else
            return standardPrice;

    }
    }
}
