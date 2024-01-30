namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareIntType()
        {
            //Arrange
            int number1 = 18;
            int number2 = 33;

            //Assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void CompareFloatType()
        {
            //Arrange
            float number1 = 15.1F;
            float number2 = 33.5F;

            //Assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void CompareStringType()
        {
            //Arrange
            string name1 = "Mikołaj";
            string name2 = "Kaczmarek";

            //Assert
            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //Arrange
            var employee1 = GetEmployee("Jarosław");
            var employee2 = GetEmployee("Jarosław");

            //Assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name, "Kaczafi");
        }
    }
}
