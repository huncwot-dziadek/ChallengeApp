namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void IsTheCalculation_Min_Max_Average_Correct()
        {
            // arrange

            var employee = new Employee("Gabriel", "Pypeæ");
            employee.AddGrade(15);
            employee.AddGrade(74);
            employee.AddGrade(52);
            employee.AddGrade(87);

            // act

            var statistics = employee.GetStatistics();
            float result1 = statistics.Min;
            float result2 = statistics.Max;
            float result3 = statistics.Average;

            // assert

            Assert.AreEqual(15, result1);
            Assert.AreEqual(87, result2);
            Assert.AreEqual(42, 75, result3);

        }
    }
}





//[SetUp]
//public void Setup()
//{
//}


