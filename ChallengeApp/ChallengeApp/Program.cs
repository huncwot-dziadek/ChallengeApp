using ChallengeApp;
using System.Diagnostics;

Console.WriteLine("Welcome to the program WHAT EMPLOYEE");
Console.WriteLine("                       =============");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Enter employee details:");
Console.Write("Name:      ");
var name = Console.ReadLine();
Console.Write("Surname:   ");

var surname = Console.ReadLine();

var employee = new Employee(name, surname);

Console.WriteLine();
Console.WriteLine("The rating should be in the range 0-100");

Console.WriteLine();
Console.WriteLine("Start entering data or exit the program by pressing key Q:");

while (true)
{
    Console.WriteLine("Give your next grade:");
    var nextInput = Console.ReadLine();

    employee.AddGrade(nextInput);

    if (employee.BadDataIndicator == 1)
    {
        Console.WriteLine("Grade is out of range 0-100, try again");
        employee.BadDataIndicator = 0;
    }
    else if (employee.BadDataIndicator == 2)
    {
        Console.WriteLine("Invalid grade, try again");
        employee.BadDataIndicator = 0;
    }
    else
    {
    }

    if (nextInput == "q" || nextInput == "Q")
    {
        break;
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee.Name} {employee.Surname} received {statistics.QuantityGrades} ratings");
Console.WriteLine($"Rating max:  {statistics.Max}");
Console.WriteLine($"Rating min:  {statistics.Min}");
Console.WriteLine($"Average ratings:  {statistics.Average:N2}");




//Console.WriteLine("You can give a rating A,B,C,D and E:");
//Console.WriteLine("A = 100 pkt");
//Console.WriteLine("B = 75 pkt");
//Console.WriteLine("C = 50 pkt");
//Console.WriteLine("D = 25 pkt");
//Console.WriteLine("E = 0 pkt");