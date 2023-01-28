

using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            // arrange

            int[] numberOfBadEntry = { 3, 5, 5, 5, 2 };

            
            
            Emploee emploeeMaciej = new Emploee("Maciej", "Cwaniaczek", "24");
            Emploee emploeeAnna = new Emploee("Anna", "Nienowacka", "33");
            Emploee emploeeWaldemar = new Emploee("Waldemar", "Pasikonik", "40");
            Emploee emploeeMarian = new Emploee("Marian", "Pocieszyciel", "42");
            Emploee emploeeMonika = new Emploee("Monika", "Skoczywlas", "22");

            emploeeMaciej.AddScore(45);
            emploeeMaciej.AddScore(5555);
            emploeeMaciej.AddScore(5);
            emploeeMaciej.AddScore(45);
            emploeeMaciej.AddScore(5);

            emploeeAnna.AddScore(5);
            emploeeAnna.AddScore(9);
            emploeeAnna.AddScore(5);
            emploeeAnna.AddScore(7);
            emploeeAnna.AddScore(5);

            emploeeWaldemar.AddScore(5);
            emploeeWaldemar.AddScore(9);
            emploeeWaldemar.AddScore(5);
            emploeeWaldemar.AddScore(8);
            emploeeWaldemar.AddScore(5);

            emploeeMarian.AddScore(1);
            emploeeMarian.AddScore(9);
            emploeeMarian.AddScore(1);
            emploeeMarian.AddScore(5);
            emploeeMarian.AddScore(5);

            emploeeMonika.AddScore(5);
            emploeeMonika.AddScore(9);
            emploeeMonika.AddScore(-7);
            emploeeMonika.AddScore(4);
            emploeeMonika.AddScore(15);
            List<Emploee> emploeeTableTest = new List<Emploee>()
            {
                 emploeeMaciej, emploeeAnna, emploeeWaldemar, emploeeMarian, emploeeMonika
            };

            // act

            int result = emploeeMaciej.BadNumbersQuantity - numberOfBadEntry[0];

            // assert

            Assert.AreEqual(0, result);



        }
    }
}





