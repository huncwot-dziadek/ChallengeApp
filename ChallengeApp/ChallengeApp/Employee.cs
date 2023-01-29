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

        float badGrade = 0;
        public void AddGrade(float grade)
        {
            if (grade > 0 && grade < 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                badGrade = grade;
                grade = 0;
                this.grades.Add(grade);
                Console.WriteLine($"Ocena {badGrade} nie mieści się w zakresie 0-100");
                Console.WriteLine("Została zamieniona oceną 0");
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
