namespace ChallengeApp.Tests
{
    public class ValueTypeUnitTest
    {
        [Test]
        public void ValueType()

        {
            // arrange
            int number1 = 1;
            double number2 = 1;
            float number3 = 1;
            string number4 = "1";


            // act


            // assert
            Assert.AreEqual(number1, number2, number3, number4);
        }

    }
}
