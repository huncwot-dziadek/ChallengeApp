using ChallengeApp;
using System;

var employee1 = new Employee("Gabriel", "Pypeć");
employee1.AddGrade("4000000");
employee1.AddGrade("30,4555");
employee1.AddGrade("Zzzzzz");
employee1.AddGrade("30,77777");

var statistics = employee1.GetStatistics();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee1.Name} {employee1.Surname} obtained the following results:");
Console.WriteLine($"Max rating: {statistics.Max}");
Console.WriteLine($"Min rating:  {statistics.Min}");
Console.WriteLine($"Average rating:  {statistics.Average:N2}");








