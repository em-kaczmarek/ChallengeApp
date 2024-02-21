using ChallengeApp;

Console.WriteLine("Welcome to the program for adding employee grades");
Console.WriteLine("For results press \"q\"");
Console.WriteLine("=================================================");

var employee = new Employee("Mikołaj", "Kaczmarek");

while (true)
{
    Console.WriteLine($"\nPlease insert {employee.Name} {employee.Surname} {employee.Sex} {employee.Age} grade:");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statisticts = employee.GetStatistics();
Console.WriteLine("");
Console.WriteLine("Statistics");
Console.WriteLine($"Employee: {employee.Name} {employee.Surname} {employee.Sex} {employee.Age}");
Console.WriteLine($"Min grade: {statisticts.Min}");
Console.WriteLine($"Max grade: {statisticts.Max}");
Console.WriteLine($"Grade average: {statisticts.Average:N2}");
Console.WriteLine($"Letter grade average: {statisticts.AverageLetter:N2}");