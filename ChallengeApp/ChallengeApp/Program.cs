using ChallengeApp;


Emploee emploee1 = new Emploee("Maciej", "Kramarczyk", "24");
Emploee emploee2 = new Emploee("Anna", "Nienowacka", "33");
Emploee emploee3 = new Emploee("Waldemar", "Pasikonik", "40");

emploee1.AddScore(1);
emploee1.AddScore(5);
emploee1.AddScore(5);
emploee1.AddScore(5);
emploee1.AddScore(5);

emploee2.AddScore(5);
emploee2.AddScore(5);
emploee2.AddScore(5);
emploee2.AddScore(5);
emploee2.AddScore(5);

emploee3.AddScore(5);
emploee3.AddScore(5);
emploee3.AddScore(5);
emploee3.AddScore(5);
emploee3.AddScore(5);

Console.WriteLine(emploee1.Result);
Console.WriteLine(emploee2.Result);
Console.WriteLine(emploee3.Result);

List<Emploee> emploeeTable = new List<Emploee>()
{
    emploee1, emploee2, emploee3
};

if (emploee1.Result == emploee2.Result && emploee1.Result == emploee3.Result)
{
    for (int j = 0; j < 1; j++)
    {
        Console.WriteLine($"Wszyscy pracownicy uzyskali tę samą liczbę punktów, tj. {emploee1.Result}");
        Console.WriteLine("Są to:");
        Console.WriteLine();
        Console.WriteLine(emploee1.Name + " " + emploee1.Surname + " lat " + emploee1.Years);
        Console.WriteLine(emploee2.Name + " " + emploee2.Surname + " lat " + emploee2.Years);
        Console.WriteLine(emploee3.Name + " " + emploee3.Surname + " lat " + emploee3.Years);
    }
}

else
{

    List<Emploee> nextWinnerTable = new List<Emploee>() { emploee1 };

    int i = 0;
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
            i = i++;
        }
    }
}

int k = i;

if (k == 0)
{
    Console.WriteLine($"Największą liczbę punktów, tj. {maxResult} uzyskał pracownik:");
    Console.WriteLine(emploeeWinner.Name + " " + emploeeWinner.Surname + " lat " + emploeeWinner.Years);

}

else
{
    Console.WriteLine($"Lista pracowników, którzy uzyskali największą liczbę punktów, tj. {maxResult}");
    Console.WriteLine("jest to następująca:");
    Console.WriteLine();
    Console.WriteLine(emploeeWinner.Name + " " + emploeeWinner.Surname + " lat " + emploeeWinner.Years);
    Console.WriteLine(nextWinner.Name + " " + nextWinner.Surname + " lat " + nextWinner.Years);
}


//foreach (var emploee in winnersTable)
//{
//    Console.WriteLine(emploeeWinner.Name + " " + emploeeWinner.Surname + " lat " + emploeeWinner.Years);
//}
