using ChallengeApp;
using System;

var employee1 = new Employee("Gabriel", "Pypeć");
employee1.AddGrade("4000000");
employee1.AddGrade("30");
employee1.AddGrade(72.553);
employee1.AddGrade(50.4f);

var statistics1 = employee1.GetStatisticsWithForEach();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithDoWhile();
var statistics4 = employee1.GetStatisticsWithWhile();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee1.Name} {employee1.Surname} obtained the following results:");
Console.WriteLine("Using the metod ForEach:");
Console.WriteLine($"Max rating: {statistics1.Max}");
Console.WriteLine($"Min rating:  {statistics1.Min}");
Console.WriteLine($"Average rating:  {statistics1.Average:N2}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee1.Name} {employee1.Surname} obtained the following results:");
Console.WriteLine("Using the metod For:");
Console.WriteLine($"Max rating: {statistics2.Max}");
Console.WriteLine($"Min rating:  {statistics2.Min}");
Console.WriteLine($"Average rating:  {statistics2.Average:N2}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee1.Name} {employee1.Surname} obtained the following results:");
Console.WriteLine("Using the metod DoWhile:");
Console.WriteLine($"Max rating: {statistics3.Max}");
Console.WriteLine($"Min rating:  {statistics3.Min}");
Console.WriteLine($"Average rating:  {statistics3.Average:N2}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{employee1.Name} {employee1.Surname} obtained the following results:");
Console.WriteLine("Using the metod While:");
Console.WriteLine($"Max rating: {statistics4.Max}");
Console.WriteLine($"Min rating:  {statistics4.Min}");
Console.WriteLine($"Average rating:  {statistics4.Average:N2}");

//List<float> statisticsAll = new List<float>();
//statisticsAll.Add(statistics1);






