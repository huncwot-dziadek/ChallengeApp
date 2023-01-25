

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            var user = new User("Krzysztof", "lakjfljslo");
            user.AddScore(5);
            user.AddScore(8);

            // act
            var result = user.Result;


            // assert
            Assert.AreEqual(13, result);

        }
    }
}