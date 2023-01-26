namespace ChallengeApp
{
    public class Emploee
    {
        private List<int> score = new List<int>();
        private List<int> nulls = new List<int>();


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

        public int NumberOfZeros
        {
            get
            {
                return this.nulls.Count();
            }
        }
        public void AddScore(int number)
        {
            if (number > 0 && number < 11)
            {
                this.score.Add(number);
            }

            else number = 0;

            this.score.Add(number);
            this.nulls.Add(number);

        }

    }

}
