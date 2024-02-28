namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        
        string Surname { get; }

        char Sex { get; }

        int Age { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
