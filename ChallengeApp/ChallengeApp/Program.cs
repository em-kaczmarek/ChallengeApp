int number = 1991;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

for (char i = '0'; i <= '9'; i++)
{
    var letterCounter = 0;

    foreach (char letter in letters)
    {
        if (i == letter)
        {
            letterCounter++;
        }
    }

    Console.WriteLine(i + " => " + letterCounter);
}