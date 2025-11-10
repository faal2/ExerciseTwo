namespace ExerciseTwo
{
    internal class Program
    {
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
        }
    }
}
