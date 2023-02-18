namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)   
            : base(name, surname)
        {
            this.FunctionInCompany = "Worker";
        }

        public override string FunctionInCompany { get; set; }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Grade out of range");
            }
        }

        public override void AddGrade(double grade)
        {
            var gradeMadeOfDouble = (float)grade;
            this.AddGrade(gradeMadeOfDouble);
        }

        public override void AddGrade(int grade)
        {
            var gradeMadeOfInt = (float)grade;
            this.AddGrade(gradeMadeOfInt);
        }

        public override void AddGrade(string grade)
        {
            //float.Parse(grade);

            if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            
            else
            {
                throw new Exception("String is not float");
            }

        }
        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(75);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(50);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(25);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(0);
                    break;

            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.QuantityGrades = 0;

            foreach (var grade in this.grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= this.grades.Count;
            statistics.QuantityGrades += this.grades.Count;

            return statistics;
        }

    }
}
