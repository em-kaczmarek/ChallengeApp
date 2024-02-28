namespace ChallengeApp.Tests
{
    public class SupervisiorTests
    {
        [Test]
        public void WhenAnSuperisiorCollectOneLetterGradesTestShouldReturnStatistics()
        {
            //Arrange
            var supervisor = new Supervisor("Jaros³aw", "Kaczafi", 'M', 999);
            supervisor.AddGrade("1");
            supervisor.AddGrade("5");
            supervisor.AddGrade("6");

            //Act
            var statistics = supervisor.GetStatistics();

            //Assert
            Assert.NotNull(statistics);
            Assert.AreEqual(10, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(63.33, statistics.Average, 0.01f);
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void WhenAnSuperisiorCollectDifferentGradesTestShouldReturnStatistics()
        {
            //Arrange
            var supervisor = new Supervisor("Jaros³aw", "Kaczafi", 'M', 999);
            supervisor.AddGrade("1+");
            supervisor.AddGrade("4-");
            supervisor.AddGrade("5+");

            //Act
            var statistics = supervisor.GetStatistics();

            //Assert
            Assert.NotNull(statistics);
            Assert.AreEqual(15, statistics.Min);
            Assert.AreEqual(85, statistics.Max);
            Assert.AreEqual(51.67, statistics.Average, 0.01f);
            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void WhenAnSuperisiorCollectWrongGradesTestShouldReturnStatistics()
        {
            //Arrange
            var supervisor = new Supervisor("Jaros³aw", "Kaczafi", 'M', 999);

            try
            {
                supervisor.AddGrade("8");
                Assert.Fail("An exception not thrown!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Wrong letter", ex.Message);
            }
            finally { }
        }
    }
}