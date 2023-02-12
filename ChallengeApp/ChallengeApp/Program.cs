﻿using ChallengeApp;
using System.Diagnostics;
using System.Net.Http.Headers;

Console.WriteLine("Welcome to the program WHAT EMPLOYEE");
Console.WriteLine("                       =============");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Enter employee details:");
Console.Write("Name:                  ");
var name = Console.ReadLine();

Console.Write("Surname:               ");
var surname = Console.ReadLine();

Console.Write("Function in Company:   ");
var functionInCompany = Console.ReadLine();

var employee = new Employee(name, surname, functionInCompany);

var supervisor = new Supervisor(name, surname, functionInCompany);

if (functionInCompany == employee.FunctionInCompany)
{

    Console.WriteLine();
    Console.WriteLine("The rating should be in the range 0-100");

    Console.WriteLine();
    Console.WriteLine("Start entering data or exit the program by pressing key Q:");

    while (true)
    {
        Console.WriteLine("Give your next grade:");
        var nextInput = Console.ReadLine();

        if (nextInput == "q" || nextInput == "Q")
        {
            break;
        }
        try
        {
            float.TryParse(nextInput, out var value);
            employee.AddGrade(value);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }

    }

    var statistics = employee.GetStatistics();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"{employee.Name} {employee.Surname} received {statistics.QuantityGrades} ratings");
    Console.WriteLine($"Rating max:  {statistics.Max}");
    Console.WriteLine($"Rating min:  {statistics.Min}");
    Console.WriteLine($"Average ratings:  {statistics.Average:N2}");

}
else if (functionInCompany == supervisor.FunctionInCompany)
{
    Console.WriteLine();
    Console.WriteLine("The rating should be in the range 0-6 with plus or minus");

    Console.WriteLine();
    Console.WriteLine("Start entering data or exit the program by pressing key Q:");

    while (true)
    {
        Console.WriteLine("Give your next grade:");
        var input = Console.ReadLine();
        if (input == "q" || input == "Q")

        {
            break;
        }
        if (input.Length == 1)
        {
            switch (input)
            {
                case "6":
                    supervisor.AddGrade(100);
                    break;
                case "5":
                    supervisor.AddGrade(80);
                    break;
                case "4":
                    supervisor.AddGrade(60);
                    break;
                case "3":
                    supervisor.AddGrade(40);
                    break;
                case "2":
                    supervisor.AddGrade(20);
                    break;
                case "1":
                    supervisor.AddGrade(0);
                    break;
            }
        }

        else
        {
            int[] grade = new int[2];


            for (int i = 0; i <= 1; i++)
            {
                switch (input[i])
                {
                    case '6':
                        grade[i] = 100;
                        break;
                    case '5':
                        grade[i] = 80;
                        break;
                    case '4':
                        grade[i] = 60;
                        break;
                    case '3':
                        grade[i] = 40;
                        break;
                    case '2':
                        grade[i] = 20;
                        break;
                    case '1':
                        grade[i] = 0;
                        break;
                    case '+':
                        grade[i] = 5;
                        break;
                    case '-':
                        grade[i] = -5;
                        break;

                }
                
            }
            supervisor.AddGrade(grade[0] + grade[1]);
        }
    }
    var statistics = supervisor.GetStatistics();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"{supervisor.Name} {supervisor.Surname} received {statistics.QuantityGrades} ratings");
    Console.WriteLine($"Rating max:  {statistics.Max}");
    Console.WriteLine($"Rating min:  {statistics.Min}");
    Console.WriteLine($"Average ratings:  {statistics.Average:N2}");
}
















//Console.WriteLine("You can give a rating A,B,C,D and E:");
//Console.WriteLine("A = 100 pkt");
//Console.WriteLine("B = 75 pkt");
//Console.WriteLine("C = 50 pkt");
//Console.WriteLine("D = 25 pkt");
//Console.WriteLine("E = 0 pkt");