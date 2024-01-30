namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenAnEmployeeCollectGradesTestShouldReturnStatistics()
        {
            //Arrange
            var employee = new Employee("Jaros³aw", "Kaczafi");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.NotNull(statistics);
            Assert.AreEqual(1, statistics.Min);
            Assert.AreEqual(4, statistics.Max);
            Assert.AreEqual(2.5, statistics.Average);
        }
    }
}