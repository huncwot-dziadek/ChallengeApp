namespace ChallengeApp
{
    public interface IEmployee
    {

        string Name { get; }
        string Surname { get; }
        string FunctionInCompany { get; }       
        public void AddGrade(float grade);
        public void AddGrade(double grade);
        public void AddGrade(int grade);
        public void AddGrade(char grade);
        public void AddGrade(string grade);

        Statistics GetStatistics();

    }
}
