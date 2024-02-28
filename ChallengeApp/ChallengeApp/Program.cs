using ChallengeApp;

Console.WriteLine("Welcome to the program for adding supervisior grades");
Console.WriteLine("For results press \"q\"");
Console.WriteLine("=================================================");

var supervisior = new Supervisor("Sandra", "Kaczmarek", 'F', 34);

while (true)
{
    Console.WriteLine($"\nPlease insert {supervisior.Name} {supervisior.Surname} {supervisior.Sex} {supervisior.Age} grade:");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    try
    {
        supervisior.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var supervisiorStatisticts = supervisior.GetStatistics();
Console.WriteLine("");
Console.WriteLine("Statistics");
Console.WriteLine($"Employee: {supervisior.Name} {supervisior.Surname} {supervisior.Sex} {supervisior.Age}");
Console.WriteLine($"Min grade: {supervisiorStatisticts.Min}");
Console.WriteLine($"Max grade: {supervisiorStatisticts.Max}");
Console.WriteLine($"Grade average: {supervisiorStatisticts.Average:N2}");
Console.WriteLine($"Letter grade average: {supervisiorStatisticts.AverageLetter:N2}");