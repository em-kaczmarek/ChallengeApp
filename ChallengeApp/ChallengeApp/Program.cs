using ChallengeApp;

var employee = new Employee("Mikołaj", "Kaczmarek");

employee.AddGrade("1");
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(4);
employee.AddGrade(5);

var statisticts = employee.GetStatisticsWithForEach();
Console.WriteLine("GetStatistics");
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Min grade: {statisticts.Min}");
Console.WriteLine($"Max grade: {statisticts.Max}");
Console.WriteLine($"Grade average: {statisticts.Average:N2}");

var statisticts1 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("");
Console.WriteLine("GetStatisticsWithDoWhile");
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Min grade: {statisticts1.Min}");
Console.WriteLine($"Max grade: {statisticts1.Max}");
Console.WriteLine($"Grade average: {statisticts1.Average:N2}");

var statisticts2 = employee.GetStatisticsWithWhile();
Console.WriteLine("");
Console.WriteLine("GetStatisticsWithWhile");
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Min grade: {statisticts2.Min}");
Console.WriteLine($"Max grade: {statisticts2.Max}");
Console.WriteLine($"Grade average: {statisticts2.Average:N2}");

var statisticts3 = employee.GetStatisticsWithFor();
Console.WriteLine("");
Console.WriteLine("GetStatisticsWithFor");
Console.WriteLine($"Employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Min grade: {statisticts3.Min}");
Console.WriteLine($"Max grade: {statisticts3.Max}");
Console.WriteLine($"Grade average: {statisticts3.Average:N2}");