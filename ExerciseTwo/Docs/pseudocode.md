Pseudocode

Huvudmeny

Main ()


const int youthPrice = 80
const int seniorPrice = 90
const int standardPrice = 120

const int youthAgeLimit = 20
const int seniorAgeLimit = 64

bool caseTwoWays = random. bool

continueIteation = true
while (continueInteraction)
Välkommen till huvudmenyn.
Här har du följande handlingar du kan utföra. Du interagerar genom att skriva in siffran till det alternativ du vill göra:

Tryck "0" om du vill avsluta programmet.
Tryck "1" om du vill se priserna för biobiljetter.
Tryck "2" om du vill se totala priset för ett eller flera sällskap.
Tryck "3" om du vill se repeterad text som du matar in 10 gånger. 
Tryck "4" om du vill se det tredje ordet från en text som du matar in. 

Skriv: 
if (!int.TryParse(Console.ReadLine(), out int userNumber))
{
    Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
}
 
	Switch (userNumber)
		Case 0:
			Console.WriteLine("Du har avslutat programmet")
			continueIteation = false
		Case 1:
			Console.WriteLine("Priserna skiljer beroende på ålder. Ange ålder för att se priser: ")
			Skriv:
			if (!int.TryParse(Console.ReadLine(), out int givenAge))
			{
    			Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
			}

			price = priceForAge (givenAge)
 			if price = youthPrice
 				console.WriteLine ("Ungdomspris: {price}kr")
 			else 
				if price = seniorPrice
 					console.WriteLine (" Pensionärspris: {price}kr")
 				else
 					console.WriteLine (" Standardpris: {price}kr"
		Case 2:
			totalCost = 0
			Console.WriteLine (Hur många i sällskap?)
			Skriv:
			if (!int.TryParse(Console.ReadLine(), out int userCompanions))
 			{
    			Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
 			}

			if userCompanions < 1
    				Console.WriteLine "Du måste ha minst ett sällskap."
			else
				Console.WriteLine ("Nu ska du ange ålden/ålderna på sällskapet. En i taget. Siffran framför kommer visa vilken person detta gäller: ")
				for loop i userCompanions
     					Console.WriteLine ("{i+1}. Skriv: ")
					if (!int.TryParse(Console.ReadLine(), out int age))
			{
    			Console.WriteLine("Felaktig inskrivning. Det måste vara en siffra. ");
			}

    					price = priceForAge(age)
    					totalCost +=price
				Console.WriteLine("Antal personer: {userCompanions}")
				Console.WriteLine("Totalkostnad för hela sällskapet: {totalCost}kr")
		Case 3:
			if (caseTwoWays)
			(jag vill använda Console.Write för att träna.)
			Console.WriteLine "Text som du vill repetera 10 gånger."
			Skriv:
			userText = Console.ReadLine()
			for loop 10 times
			Console.Write ({i + 1}. {userText}, )
			
			else
			(jag vill använda stringbuilder för att träna.)
			string repeat = "";
			Console.WriteLine "Text som du vill repetera 10 gånger."
 			Skriv:
 			userText = Console.ReadLine()
 			for loop 10 times
				repeat += $"{i + 1}. {userText}, ";
 			stringbuilder trim last character. 
			Console.Write ({i + 1}. {userText}, )

		Case 4:
			Console.WriteLine "Skriv flera ord, så visar jag dig det tredje ordet."
			Skriv: 
			userText = Console.ReadLine()
			splitUserText = userText.Split()
			if splitUserText.Length < 3
				Console.WriteLine("Write at least three words next time.")
			else
				thirdWord = splitUserText[2]
				Console.WriteLine(thirdWord)
		default:
			Console.WriteLine "Du har angett fel. Läs instruktionerna noga."




int priceForAge (int age)
	if age < youthAgeLimit
		return youthPrice
	else if age > seniorAgeLimit
		return seniorPrice
	else
		return standardPrice






