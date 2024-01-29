namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenAnEmployeeCollectPositiveGradesTestShouldReturnSum()
        {
            //Arrange
            var employee = new Employee("Jaros³aw", "Kaczafi", 74);
            employee.AddGrade(1);
            employee.AddGrade(2);

            //Act
            var result = employee.Result;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void WhenAnEmployeeCollectMixedGradesTestShouldReturnSum()
        {
            //Arrange
            var employee = new Employee("Adrian", "Duda", 51);
            employee.AddGrade(10);
            employee.AddGrade(5);
            employee.AddGrade(-20);

            //Act
            var result = employee.Result;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(-5, result);
        }
    }
}