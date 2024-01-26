using ChallengeApp;

var employee1 = new Employee("Sandra", "Kaczmarek", 34);
var employee2 = new Employee("Mikołaj", "Kaczmarek", 33);
var employee3 = new Employee("Łukasz", "Kaczmarek", 99);

employee1.AddGrade(1);
employee1.AddGrade(2);
employee1.AddGrade(3);
employee1.AddGrade(4);
employee1.AddGrade(5);

employee2.AddGrade(3);
employee2.AddGrade(4);
employee2.AddGrade(5);
employee2.AddGrade(6);
employee2.AddGrade(7);

employee3.AddGrade(5);
employee3.AddGrade(6);
employee3.AddGrade(7);
employee3.AddGrade(8);
employee3.AddGrade(9);

List<Employee> employees = new()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine($"Pracownik z najwyższą liczbą ocen to: {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} {employeeWithMaxResult.Age} lat. Zdobyty wynik to: {maxResult} punktów.");