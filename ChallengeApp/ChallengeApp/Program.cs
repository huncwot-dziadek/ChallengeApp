using ChallengeApp;


Emploee emploeeMaciej = new Emploee("Maciej", "Cwaniaczek", "24");
Emploee emploeeAnna = new Emploee("Anna", "Nienowacka", "33");
Emploee emploeeWaldemar = new Emploee("Waldemar", "Pasikonik", "40");
Emploee emploeeMarian = new Emploee("Marian", "Pocieszyciel", "42");
Emploee emploeeMonika = new Emploee("Monika", "Skoczywlas", "22");


emploeeMaciej.AddScore(45);
emploeeMaciej.AddScore(5555);
emploeeMaciej.AddScore(5);
emploeeMaciej.AddScore(45);
emploeeMaciej.AddScore(5);

emploeeAnna.AddScore(5);
emploeeAnna.AddScore(9);
emploeeAnna.AddScore(5);
emploeeAnna.AddScore(7);
emploeeAnna.AddScore(5);

emploeeWaldemar.AddScore(5);
emploeeWaldemar.AddScore(9);
emploeeWaldemar.AddScore(5);
emploeeWaldemar.AddScore(8);
emploeeWaldemar.AddScore(5);

emploeeMarian.AddScore(1);
emploeeMarian.AddScore(9);
emploeeMarian.AddScore(1);
emploeeMarian.AddScore(5);
emploeeMarian.AddScore(5);

emploeeMonika.AddScore(5);
emploeeMonika.AddScore(9);
emploeeMonika.AddScore(-7);
emploeeMonika.AddScore(4);
emploeeMonika.AddScore(15);

List<Emploee> emploeeTable = new List<Emploee>()
{
    emploeeMaciej, emploeeAnna, emploeeWaldemar, emploeeMarian, emploeeMonika
};

int maxResult = -1;

foreach (var emploee in emploeeTable)
{
    if (emploee.Result > maxResult)
    {
        maxResult = emploee.Result;
    }
}

Console.WriteLine($"Pracownicy, którzy uzyskali najlepszy wynik, tj. {maxResult}");
Console.WriteLine();

foreach (var emplo in emploeeTable)
{
    if (emplo.Result >= maxResult)
    {
        Console.WriteLine(emplo.Name + " " + emplo.Surname + " lat " + emplo.Years);
    }
}


Console.WriteLine();
Console.WriteLine();


Console.WriteLine($"Lista pracowników, którzy chcieli przechytrzyć nasz system ocen");
Console.WriteLine($"lub pomyłkowo wprowadzili złe dane:");
Console.WriteLine();


foreach (var emplo in emploeeTable)
{
    if (emplo.BadNumbersQuantity > 0)
    {
        Console.WriteLine($"{emplo.Name} {emplo.Surname} lat {emplo.Years} - {emplo.BadNumbersQuantity} złe wpisy");
    }
}
