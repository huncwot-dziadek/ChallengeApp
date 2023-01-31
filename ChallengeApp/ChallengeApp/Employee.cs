namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                if ((grade - Math.Floor(grade)) >= 0.5)
                {
                    this.grades.Add((float)Math.Ceiling(grade));       
                }
                else
                {
                    this.grades.Add((float)Math.Floor(grade));
                }
            }
            else
            {
                Console.WriteLine($"Grade is out of range 0-100, try again");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else if (double.TryParse(grade, out double resultDouble))
            {
                var valueInDouble = (float)resultDouble;
                this.AddGrade(valueInDouble);
            }
            else if (short.TryParse(grade, out short resultShort))
            {
                var valueInShort = (float)resultShort;
                this.AddGrade(valueInShort);
            }
            else if (long.TryParse(grade, out long resultLong))
            {
                var valueInLong = (float)resultShort;
                this.AddGrade(valueInLong);
            }
            else
            {
                Console.WriteLine($"Invalid grade, try again");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }


    }
}
