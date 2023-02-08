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

        public string Name { get; set; }
        public string Surname { get; private set; }
        public int BadDataIndicator { get; set; }

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
//public void AddGrade(double grade)
//{
//    var gradeMadeOfDouble = (float)grade;
//    this.AddGrade(gradeMadeOfDouble);
//}
//public void AddGrade(long grade)
//{
//    var gradeMadeOfLong = (float)grade;
//    this.AddGrade(gradeMadeOfLong);
//}
//public void AddGrade(short grade)
//{
//    var gradeMadeOfShort = (float)grade;
//    this.AddGrade(gradeMadeOfShort);
//}
//public void AddGrade(int grade)
//{
//    var gradeMadeOfInt = (float)grade;
//    this.AddGrade(gradeMadeOfInt);
//}
//public void AddGrade(char grade)
//{
//    switch (grade)
//    {
//        case 'A':
//        case 'a':
//            this.grades.Add(100);
//            break;
//        case 'B':
//        case 'b':
//            this.grades.Add(75);
//            break;
//        case 'C':
//        case 'c':
//            this.grades.Add(50);
//            break;
//        case 'D':
//        case 'd':
//            this.grades.Add(25);
//            break;
//        case 'E':
//        case 'e':
//            this.grades.Add(0);
//            break;

//            Console.WriteLine("Wrong Letter, try again");
//    } //}




//switch (statistics.Average)
//{
//    case var average when average > 80:
//        statistics.AverageLetter = 'A';
//        break;
//    case var average when average > 60:
//        statistics.AverageLetter = 'B';
//        break;
//}
