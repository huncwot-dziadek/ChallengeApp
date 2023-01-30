namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void IsTheCalculation_Min_Max_Average_Correct()
        {
            // arrange

            var employee = new Employee("Gabriel", "Pype�");
            employee.AddGrade(15);
            employee.AddGrade(74);
            employee.AddGrade(52);
            employee.AddGrade(87);

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(15, statistics.Min);
            Assert.AreEqual(87, statistics.Max);
            Assert.AreEqual(Math.Round(57.00, 2), Math.Round(statistics.Average, 2));
        }
    }
}



