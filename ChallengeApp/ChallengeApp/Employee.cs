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
                    grade = (float)grade;
                    this.grades.Add((float)Math.Ceiling(grade));        //int valueInInt = (int)grade   - jak wykorzystać
                }
                else
                {
                    this.grades.Add((float)Math.Floor(grade));
                }
            }
            else
            {
                Console.WriteLine($"Grade is out of range 0-100 or is not float, try again");
            }
            {
                this.AddGrade(grade);
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Grade is not float, try again");
            }
        }

        public void AddGrade(double grade)
        {
            if (float.TryParse((float)grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Grade is not float, try again");
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
