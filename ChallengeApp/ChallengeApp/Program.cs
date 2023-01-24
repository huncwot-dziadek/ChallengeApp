using ChallengeApp;
using System.Collections.Immutable;

Emploee emploee1 = new Emploee("Maciej", "Kramarczyk", "24");
Emploee emploee2 = new Emploee("Anna", "Nienowacka", "33");
Emploee emploee3 = new Emploee("Waldemar", "Pasikonik", "40");

emploee1.AddScore(7); emploee1.AddScore(1); emploee1.AddScore(8); emploee1.AddScore(6); emploee1.AddScore(9);
emploee2.AddScore(4); emploee2.AddScore(1); emploee2.AddScore(8); emploee2.AddScore(9); emploee2.AddScore(9);
emploee3.AddScore(9); emploee3.AddScore(9); emploee3.AddScore(9); emploee3.AddScore(3); emploee3.AddScore(1);

List<int> TemporaryList = new List<int>();

TemporaryList.Add(emploee1.Result);
TemporaryList.Add(emploee2.Result);
TemporaryList.Add(emploee3.Result);

var max = TemporaryList.Max(); var indexMax = TemporaryList.IndexOf(max);
var min = TemporaryList.Min(); var indexMin = TemporaryList.IndexOf(min);

string outEmpl1 = "emploee1.name +emploee1.surname +lat emploee1.years ";
string outEmpl2 = "emploee2.name +emploee2.surname +lat emploee2.years ";
string outEmpl3 = "emploee3.name +emploee3.surname +lat emploee3.years ";

int k = 6;
    
    if (emploee1.Result == emploee2.Result && emploee1.Result == emploee3.Result)
{
    Console.WriteLine($"Wszyscy pracownicy osiągnęli ten sam wynik, który wynosi {max}. Są to");
    Console.WriteLine($"{outEmpl1}");
    Console.WriteLine("outEmpl2");
    Console.WriteLine("outEmpl3");



}

else if (emploee1.Result != emploee2.Result && emploee1.Result != emploee3.Result && emploee2.Result != emploee3.Result)
{
    //indexMax
}




    Console.WriteLine(max);
Console.WriteLine(indexMax);
Console.WriteLine(min);
Console.WriteLine(indexMin);





//for (int i = 0; i <= WorkList1.Count; i++)





foreach (var ddd in TemporaryList)
{
    Console.WriteLine(ddd);
}
