using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {

        private List<float> gradesSupervisor = new List<float>();

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
                this.gradesSupervisor.Add(grade);
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
                    this.gradesSupervisor.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.gradesSupervisor.Add(75);
                    break;
                case 'C':
                case 'c':
                    this.gradesSupervisor.Add(50);
                    break;
                case 'D':
                case 'd':
                    this.gradesSupervisor.Add(25);
                    break;
                case 'E':
                case 'e':
                    this.gradesSupervisor.Add(0);
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
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.QuantityGrades = 0;

            foreach (var grade in this.gradesSupervisor)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= this.gradesSupervisor.Count;
            statistics.QuantityGrades += this.gradesSupervisor.Count;

            return statistics;
        }
    }
}
