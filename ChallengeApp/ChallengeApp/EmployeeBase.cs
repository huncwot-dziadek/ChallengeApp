namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void EmployeeGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("dodano nową ocenę");
        }

        public abstract void Info_o_ocenie(object sender, EventArgs args);

        public abstract string FunctionInCompany { get; set; }


        public abstract void AddGrade(float grade);


        public abstract void AddGrade(double grade);


        public abstract void AddGrade(int grade);


        public abstract void AddGrade(char grade);


        public abstract void AddGrade(string grade);


        public abstract Statistics GetStatistics();

    }
}
