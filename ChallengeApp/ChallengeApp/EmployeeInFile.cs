namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        private const string fileName = "grades4.txt";

        private List<float> numbers = new List<float>();

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
            this.FunctionInCompany = "Worker";
        }

        public override string FunctionInCompany { get; set; }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(double grade)
        {
            var gradeMadeOfDouble = (float)grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(gradeMadeOfDouble);
            }
        }

        public override void AddGrade(int grade)
        {
            var gradeMadeOfInt = (float)grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(gradeMadeOfInt);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override Statistics GetStatistics()
        {

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        numbers.Add(number);
                        line = reader.ReadLine();
                    }

                }

            }

            var result = this.GetStatistics(numbers);
            return result;
        }

        private Statistics GetStatistics(List<float> numbers)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.QuantityGrades = 0;

            foreach (var grade in this.numbers)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= this.numbers.Count;
            statistics.QuantityGrades += this.numbers.Count;

            return statistics;
        }
    }
}
