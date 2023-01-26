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
emploee2.AddScore(7);
emploee2.AddScore(7);
emploee2.AddScore(5);

emploee3.AddScore(5);
emploee3.AddScore(9);
emploee3.AddScore(7);
emploee3.AddScore(3);
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
    Console.WriteLine($"Wszyscy pracownicy uzyskali tę samą liczbę punktów, tj. {emploee1.Result}");
    Console.WriteLine("Są to:");
    Console.WriteLine();
    Console.WriteLine(emploee1.Name + " " + emploee1.Surname + " lat " + emploee1.Years);
    Console.WriteLine(emploee2.Name + " " + emploee2.Surname + " lat " + emploee2.Years);
    Console.WriteLine(emploee3.Name + " " + emploee3.Surname + " lat " + emploee3.Years);
}

else if (emploee1.Result != emploee2.Result && emploee1.Result != emploee3.Result && emploee2.Result != emploee3.Result)
{
    int maxResult = -1;
    Emploee emploeeWinner = null;

    foreach (var emploee in emploeeTable)
    {
        if (emploee.Result > maxResult)
        {
            emploeeWinner = emploee;
            maxResult = emploee.Result;
        }

        else if (emploee.Result == maxResult)
        {
            emploeeWinner = emploee;
        }
    }
    Console.WriteLine($"Pracownikiem, który uzyskał największą liczbę punktów, tj. {maxResult} jest:");
    Console.WriteLine("");
    Console.WriteLine(emploeeWinner.Name + " " + emploeeWinner.Surname + " lat " + emploeeWinner.Years);
}

else
{
    if (emploee1.Result == emploee2.Result && emploee1.Result < emploee3.Result)
    {
        Console.WriteLine($"Pracownikiem, który uzyskał największą liczbę punktów, tj. {emploee3.Result} jest:");
        Console.WriteLine("");
        Console.WriteLine(emploee3.Name + " " + emploee3.Surname + " lat " + emploee3.Years);
    }
    else if (emploee1.Result == emploee2.Result && emploee1.Result > emploee3.Result)
    {
        Console.WriteLine($"Pracownikami, którzy uzyskali największą liczbę punktów, tj. {emploee1.Result} są:");
        Console.WriteLine("");
        Console.WriteLine(emploee1.Name + " " + emploee1.Surname + " lat " + emploee1.Years);
        Console.WriteLine(emploee2.Name + " " + emploee2.Surname + " lat " + emploee2.Years);
    }
    else if (emploee2.Result == emploee3.Result && emploee1.Result > emploee2.Result)
    {
        Console.WriteLine($"Pracownikiem, który uzyskał największą liczbę punktów, tj. {emploee1.Result} jest:");
        Console.WriteLine("");
        Console.WriteLine(emploee1.Name + " " + emploee1.Surname + " lat " + emploee1.Years);
    }
    else if (emploee2.Result == emploee3.Result && emploee1.Result < emploee2.Result)
    {
        Console.WriteLine($"Pracownikami, którzy uzyskali największą liczbę punktów, tj. {emploee2.Result} są:");
        Console.WriteLine("");
        Console.WriteLine(emploee2.Name + " " + emploee2.Surname + " lat " + emploee2.Years);
        Console.WriteLine(emploee3.Name + " " + emploee3.Surname + " lat " + emploee3.Years);
    }

    else if (emploee1.Result == emploee3.Result && emploee1.Result < emploee2.Result)
    {
        Console.WriteLine($"Pracownikiem, który uzyskał największą liczbę punktów, tj. {emploee2.Result} jest:");
        Console.WriteLine("");
        Console.WriteLine(emploee2.Name + " " + emploee2.Surname + " lat " + emploee2.Years);
    }

    else
    {
        Console.WriteLine($"Pracownikami, którzy uzyskali największą liczbę punktów, tj. {emploee1.Result} są:");
        Console.WriteLine("");
        Console.WriteLine(emploee1.Name + " " + emploee1.Surname + " lat " + emploee1.Years);
        Console.WriteLine(emploee3.Name + " " + emploee3.Surname + " lat " + emploee3.Years);
    }


}


