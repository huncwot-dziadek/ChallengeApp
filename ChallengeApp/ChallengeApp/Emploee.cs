namespace ChallengeApp
{
    public class Emploee
    {
        private List<int> score = new List<int>();

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
        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }

}
