using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, string functionInCompany)
        {
            this.Name = name;
            this.Surname = surname;
            this.FunctionInCompany = "Manager";
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

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }

        //public Statistics GetStatistics()
        //{
        //    var statistics = new Statistics();
        //    statistics.Average = 0;
        //    statistics.Max = float.MinValue;
        //    statistics.Min = float.MaxValue;
        //    statistics.QuantityGrades = 0;

        //    foreach (var grade in this.gradesSupervisor)
        //    {
        //        statistics.Average += grade;
        //        statistics.Max = Math.Max(statistics.Max, grade);
        //        statistics.Min = Math.Min(statistics.Min, grade);
        //    }

        //    statistics.Average /= this.gradesSupervisor.Count;
        //    statistics.QuantityGrades += this.gradesSupervisor.Count;

        //    return statistics;
        //}
    }
}
