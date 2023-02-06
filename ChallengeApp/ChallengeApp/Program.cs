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
Console.WriteLine("You can give a rating A,B,C,D and E:");
Console.WriteLine("A = 100 pkt");
Console.WriteLine("B = 75 pkt");
Console.WriteLine("C = 50 pkt");
Console.WriteLine("D = 25 pkt");
Console.WriteLine("E = 0 pkt");

Console.WriteLine();
Console.WriteLine("Start entering data or exit the program by pressing key Q:");
//Console.WriteLine("Give your first grade:");



   // var firstInput = Console.ReadLine();
    //employee.AddGrade(firstInput);

while (true)
{
    Console.WriteLine("Give your next grade:");
    var nextInput = Console.ReadLine();

    if (float.TryParse(nextInput, out float resultFloat))
    {
        if (resultFloat >= 0 && resultFloat <= 100)
        {
                        employee.AddGrade(resultFloat);
        }
        else
        {           
                Console.WriteLine($"Grade is out of range 0-100, try again");
           
        }
    }
    else
    {
        int indicator = 0;
        switch (nextInput)
        {
            case "A":
            case "a":
                employee.AddGrade(100);
                indicator++;
                break;
            case "B":
            case "b":
                employee.AddGrade(75);
                indicator++;
                break;
            case "C":
            case "c":
                employee.AddGrade(50);
                indicator++;
                break;
            case "D":
            case "d":
                employee.AddGrade(25);
                indicator++;
                break;
            case "E":
            case "e":
                employee.AddGrade(0);
                indicator++;
                break;
        }

        if (indicator == 0)
        {
            Console.WriteLine($"Invalid grade or wrong letter, try again");
        }
    }


           if (nextInput == "q" || nextInput == "Q")
    {
        //var nextInputWhenBreak = (float)0.00;
        //employee.AddGrade(nextInputWhenBreak);
        //Console.WriteLine("Nie wprowadzono żadnych ocen");
        break;
    }

    
    //employee.AddGrade(nextInput);
  
}






var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee.Name} {employee.Surname} received {statistics.QuantityGrades} ratings");
Console.WriteLine($"Rating max:  {statistics.Max}");
Console.WriteLine($"Rating min:  {statistics.Min}");
Console.WriteLine($"Average ratings:  {statistics.Average:N2}");





