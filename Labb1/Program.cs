/*Labb1 – Hitta tal i sträng med tecken
Skapa en konsollapplikation som ber användaren mata in en text (string) i konsollen.
Den inmatade strängen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan.


ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
t.ex 95a9 är inte heller ett korrekt tal.

Skriv ut och markera varje korrekt delsträng
För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
rad med hela strängen, men där delsträngen är markerad i en annan färg.
Exempel output för input ”29535123p48723487597645723645”:

29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645
29535123p48723487597645723645

Ni kan välja vilka färger ni skriver ut med så länge man ser skillnad på dem. Ni
byter färg genom att ändra värde på Console.ForegroundColor.

Addera ihop alla tal och skriv ut totalen
Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
Exempel output för input ”29535123p48723487597645723645”:
Total = 5836428677242

*/

//string input = Console.ReadLine();
using System.Diagnostics.Metrics;

string input = "29535123p48723487597645723645";
//string firstNumber = "";29535123p48723487597645723645
string text = "";
string test = "2348759764";
string subTest = "";
char firstNumber = ' ';

bool isInBlueZone123 = false;

int[] startEndIndexOf = new int[2];

for (int i = 0; i < input.Length; i++)
{

    for (int j = i; j < input.Length; j++)
    {
        text += input[j];
        firstNumber = text[0];

        if (firstNumber == input[j] && long.TryParse(text, out long a) && text.Count(n => n == firstNumber) == 2)
        {
            startEndIndexOf[0] = input.IndexOf(text);
            startEndIndexOf[1] = startEndIndexOf[0] + text.Length - 1;

            for (int k = 0; k < input.Length; k++)
            {
                if (k >= startEndIndexOf[0] && k <= startEndIndexOf[1])
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(input[k]);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(input[k]);
                }
            }
            Console.WriteLine();


        }



    }

    subTest = "";

    text = "";
    //Console.WriteLine();

}


