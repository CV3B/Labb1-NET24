
string input = Console.ReadLine();
string currentInputSubString = "";

char firstCharInSubString = ' ';

long sumOfMarkedNum = 0;

int startIndexOfMarkedNum = 0;
int endIndexOfMarkedNum = 0;

Console.WriteLine();

for (int i = 0; i < input.Length; i++)
{

    for (int j = i; j < input.Length; j++)
    {
        currentInputSubString += input[j];
        firstCharInSubString = currentInputSubString[0];


        if (firstCharInSubString == input[j] && long.TryParse(currentInputSubString, out long _) && currentInputSubString.Count(n => n == firstCharInSubString) == 2)
        {
            startIndexOfMarkedNum = i;
            endIndexOfMarkedNum = j;

            sumOfMarkedNum += long.Parse(currentInputSubString);

            for (int k = 0; k < input.Length; k++)
            {
                if (k >= startIndexOfMarkedNum && k <= endIndexOfMarkedNum)
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

    currentInputSubString = "";

    Console.ResetColor();
}

Console.WriteLine($"\nTotal = {sumOfMarkedNum}");