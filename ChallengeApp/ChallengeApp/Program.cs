﻿using ChallengeApp;
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

var sex = Console.ReadLine();

var ageString = Console.ReadLine();
var age = int.Parse(ageString);

var functionInCompany = Console.ReadLine();

var employee = new Employee(name, surname, sex, age, functionInCompany);

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
        employee.AddGrade(nextInput);
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




//Console.WriteLine("You can give a rating A,B,C,D and E:");
//Console.WriteLine("A = 100 pkt");
//Console.WriteLine("B = 75 pkt");
//Console.WriteLine("C = 50 pkt");
//Console.WriteLine("D = 25 pkt");
//Console.WriteLine("E = 0 pkt");