﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<int> grades = new();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return grades.Sum();
            }
        }

        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
        }
    }
}
