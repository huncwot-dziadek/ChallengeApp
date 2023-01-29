﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace ChallengeApp
{
    public class PreviousEmploee
    {
        private List<int> score = new List<int>();
        private List<int> setOfBadNumbers = new List<int>();


        public PreviousEmploee(string name, string surname, string years)
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
                return this.setOfBadNumbers.Count();
            }
        }

        public void AddScore(int number)
        {
            if (number > 0 && number < 11)
            {
                this.score.Add(number);
            }

            else
            {
                var BadNumber = number;
                number = BadNumber - number;
                this.score.Add(number);
                this.setOfBadNumbers.Add(BadNumber);
            }

        }

    }

}
