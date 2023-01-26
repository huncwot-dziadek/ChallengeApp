

using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            var emploee = new Emploee("Mieczys³aw", "Kowalski", "33");
            emploee.AddScore(7);
            emploee.AddScore(4);

            // act
            var result = emploee.Result;

            // assert
            Assert.AreEqual(10, result);

        }
    }
}

