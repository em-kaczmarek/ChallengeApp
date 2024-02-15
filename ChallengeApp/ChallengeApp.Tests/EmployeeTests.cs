namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenAnEmployeeCollectGradesTestShouldReturnStatistics()
        {
            //Arrange
            var employee = new Employee("Jaros³aw", "Kaczafi");
            employee.AddGrade("10");
            employee.AddGrade(20);
            employee.AddGrade(30);
            employee.AddGrade('A');

            //Act
            var statistics = employee.GetStatistics();

            //Assert
            Assert.NotNull(statistics);
            Assert.AreEqual(10, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(40, statistics.Average);
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}