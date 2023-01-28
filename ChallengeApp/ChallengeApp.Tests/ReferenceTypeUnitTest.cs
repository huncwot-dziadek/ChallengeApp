namespace ChallengeApp.Tests
{
    public class ReferenceTypeUnitTest
    {
        [Test]
        public void ReferenceType()

        {
            // arrange
            var user1 = GetUser("Bolek");
            var user2 = GetUser("Lolek");


            // act


            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        { 
        return new User(name);
        }
    }
}
