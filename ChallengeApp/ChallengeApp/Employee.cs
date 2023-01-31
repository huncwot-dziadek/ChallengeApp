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
                this.grades.Add(grade);
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
            else
            {
                Console.WriteLine($"Invalid grade, try again");
            }
        }

        public void AddGrade(double grade)
        {
            var gradeMadeOfDouble = (float)grade;
            this.AddGrade(gradeMadeOfDouble);
        }
        public void AddGrade(long grade)
        {
            var gradeMadeOfLong = (float)grade;
            this.AddGrade(gradeMadeOfLong);
        }
        public void AddGrade(short grade)
        {
            var gradeMadeOfShort = (float)grade;
            this.AddGrade(gradeMadeOfShort);
        }
        public void AddGrade(int grade)
        {
            var gradeMadeOfInt = (float)grade;
            this.AddGrade(gradeMadeOfInt);
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
