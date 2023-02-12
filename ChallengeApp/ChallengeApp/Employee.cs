namespace ChallengeApp
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();


        public Employee(string name, string surname, string functionInCompany)

        {
            this.Name = name;
            this.Surname = surname;
            this.FunctionInCompany = "Worker";
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string FunctionInCompany { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Grade out of range");
            }
        }

        public void AddGrade(double grade)
        {
            var gradeMadeOfDouble = (float)grade;
            this.AddGrade(gradeMadeOfDouble);
        }

        public void AddGrade(int grade)
        {
            var grademadeofint = (float)grade;
            this.AddGrade(grademadeofint);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else
            {
                throw new Exception("String is not float");
            }

        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(75);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(50);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(25);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(0);
                    break;

            }
        }

        public Statistics GetStatistics()
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







//    else
//    {
//        int indicator = 0;
//        switch (grade)
//        {
//            case "A":
//            case "a":
//                this.grades.Add(100);
//                this.Lampka = 0;
//                indicator++;
//                break;
//            case "B":
//            case "b":
//                this.grades.Add(75);
//                this.Lampka = 0;
//                indicator++;
//                break;
//            case "C":
//            case "c":
//                this.grades.Add(50);
//                this.Lampka = 0;
//                indicator++;
//                break;
//            case "D":
//            case "d":
//                this.grades.Add(25);
//                this.Lampka = 0;
//                indicator++;
//                break;
//            case "E":
//            case "e":
//                this.grades.Add(0);
//                this.Lampka = 0;
//                indicator++;
//                break;

//        }

//        if (indicator == 0)
//        {
//            this.Lampka = 2;
//        }
//    }

//}




//switch (statistics.Average)
//{
//    case var average when average > 80:
//        statistics.AverageLetter = 'A';
//        break;
//    case var average when average > 60:
//        statistics.AverageLetter = 'B';
//        break;
//}
