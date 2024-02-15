using ChallengeApp;

var employee = new Employee("Mikołaj", "Kaczmarek");

employee.AddGrade("1");
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(4);
employee.AddGrade(5);

var statisticts = employee.GetStatistics();
Console.WriteLine("GetStatistics");
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Min grade: {statisticts.Min}");
Console.WriteLine($"Max grade: {statisticts.Max}");
Console.WriteLine($"Grade average: {statisticts.Average:N2}");