namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new();

        public Supervisor(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }

        public int Age { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value! The rating range: 0-100");
            }
        }

        public void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                if (float.TryParse(grade, out float result))
                {
                    AddGrade(grade[0]);
                }
                else
                {
                    throw new Exception("Grade is not a number!");
                }
            }
            else if (grade.Length == 2)
            {
                if (char.IsDigit(grade[0]) && grade[1] == '-')
                {
                    AddGrade(grade[0], '-');
                }
                else if (char.IsDigit(grade[0]) && grade[1] == '+')
                {
                    AddGrade(grade[0], '+');
                }
                else if (char.IsDigit(grade[1]) && grade[0] == '-')
                {
                    AddGrade(grade[1], '-');
                }
                else if (char.IsDigit(grade[1]) && grade[0] == '+')
                {
                    AddGrade(grade[1], '+');
                }
                else
                {
                    throw new Exception("Grade is not correct!");
                }
            }
            else
            {
                throw new Exception("Grade is too long!");
            }
        }

        public void AddGrade(char grade, char sign = ' ')
        {
            var signValue = 0;

            if (grade != '1' && sign == '-')
            {
                signValue = -5;
            }
            else if (grade != '6' && sign == '+')
            {
                signValue = 5;
            }

            switch (grade)
            {
                case '6':
                    AddGrade(100 + signValue);
                    break;
                case '5':
                    AddGrade(80 + signValue);
                    break;
                case '4':
                    AddGrade(60 + signValue);
                    break;
                case '3':
                    AddGrade(40 + signValue);
                    break;
                case '2':
                    AddGrade(20 + signValue);
                    break;
                case '1':
                    AddGrade(10 + signValue);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

    }
}
