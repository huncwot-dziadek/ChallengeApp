using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace ChallengeApp
{
    public class Emploee
    {
        private List<int> score = new List<int>();
        private List<int> badNumberValue = new List<int>();


        public Emploee(string name, string surname, string years)
        {
            this.Name = name;
            this.Surname = surname;
            this.Years = years;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Years { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public int BadNumbersQuantity
        {
            get
            {
                return this.badNumberValue.Count();
            }
        }


        int BadNumber = 0;
        public void AddScore(int number)
        {
            if (number > 0 && number < 11)
            {
                this.score.Add(number);
            }

            else
            {
                BadNumber = number;
                number = BadNumber - number;
                this.score.Add(number);
                this.badNumberValue.Add(BadNumber);
            }

        }

    }

}
