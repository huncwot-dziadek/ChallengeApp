namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void IsTheCalculation_Min_Max_Average_Correct()
        {
            // arrange

            var employee = new Employee("Gabriel", "Pypeæ");
            employee.AddGrade("4000000");
            employee.AddGrade("30,4555");
            employee.AddGrade("Zzzzzz");
            employee.AddGrade("30,77777");

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(30, statistics.Min);
            Assert.AreEqual(31, statistics.Max);
            Assert.AreEqual(Math.Round(30.5, 2), Math.Round(statistics.Average, 2));
        }
    }
}



