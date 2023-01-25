using ChallengeApp;
using System.Collections.Immutable;

Emploee emploee1 = new Emploee("Maciej", "Kramarczyk", "24");
Emploee emploee2 = new Emploee("Anna", "Nienowacka", "33");
Emploee emploee3 = new Emploee("Waldemar", "Pasikonik", "40");

emploee1.AddScore(7);
emploee1.AddScore(1);
emploee1.AddScore(8);
emploee1.AddScore(6);
emploee1.AddScore(9);

emploee2.AddScore(3);
emploee2.AddScore(22);
emploee2.AddScore(5);
emploee2.AddScore(9);
emploee2.AddScore(9);

emploee3.AddScore(9);
emploee3.AddScore(39);
emploee3.AddScore(8);
emploee3.AddScore(3);
emploee3.AddScore(1);

Console.WriteLine(emploee1.Result);
Console.WriteLine(emploee2.Result);
Console.WriteLine(emploee3.Result);

List<Emploee> emploeeTable = new List<Emploee>()
{
    emploee1, emploee2, emploee3
};

List<Emploee> nextWinnerTable = new List<Emploee>() { emploee1};

int maxResult = -1;
Emploee emploeeWinner = null;
Emploee nextWinner = null;

foreach (var emploee in emploeeTable)
{
    if (emploee.Result > maxResult)
    {
        emploeeWinner = emploee;
        maxResult = emploee.Result;
    }

    else if (emploee.Result == maxResult)
    {
        nextWinner = emploeeWinner;            
        emploeeWinner = emploee;

    }
}

//Console.WriteLine($"Największą liczbę punktów, tj. {maxResult} uzyskał pracownik:");
//Console.WriteLine(emploeeWinner.Name+" " + emploeeWinner.Surname + " lat " + emploeeWinner.Years);


Console.WriteLine($"Lista pracowników, którzy uzyskali największą liczbę punktów, tj. {maxResult}");
Console.WriteLine("jest to następująca:");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(emploeeWinner.Name + " " + emploeeWinner.Surname + " lat " + emploeeWinner.Years);
//Console.WriteLine(nextWinner.Name + " " + nextWinner.Surname + " lat " + nextWinner.Years);



//foreach (var emploee in winnersTable)
//{
//    Console.WriteLine(emploeeWinner.Name + " " + emploeeWinner.Surname + " lat " + emploeeWinner.Years);
//}
