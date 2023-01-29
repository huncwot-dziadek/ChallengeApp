namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void IsTheCalculationMaxCorrect()
        {
            // arrange

            var employee = new Employee("Gabriel", "Pypeæ");
            employee.AddGrade(15);
            employee.AddGrade(74);
            employee.AddGrade(52);
            employee.AddGrade(87);

            // act

            var statistics = employee.GetStatistics();
            float result = statistics.Max;

            // assert

            Assert.AreEqual(87, result);
        }

        [Test]
        public void IsTheCalculationMinCorrect()
        {
            // arrange

            var employee = new Employee("Gabriel", "Pypeæ");
            employee.AddGrade(15);
            employee.AddGrade(74);
            employee.AddGrade(52);
            employee.AddGrade(87);

            // act

            var statistics = employee.GetStatistics();
            float result = statistics.Min;

            // assert

            Assert.AreEqual(15, result);
        }

        [Test]
        public void IsTheCalculationAverageCorrect()
        {
            // arrange

            var employee = new Employee("Gabriel", "Pypeæ");
            employee.AddGrade(15);
            employee.AddGrade(74);
            employee.AddGrade(52);
            employee.AddGrade(87);

            // act

            var statistics = employee.GetStatistics();
            float result = statistics.Average;

            // assert

            Assert.AreEqual(57, result);
        }
    }
}





//[SetUp]
//public void Setup()
//{
//}


