using ChallengeApp;

Emploee emploee1 = new Emploee("Maciej", "Kramarczyk", "29");
Emploee emploee2 = new Emploee("Anna", "Nienowacka", "33");
Emploee emploee3 = new Emploee("Waldemar", "Pasikonik", "37");

emploee1.AddScore(7); emploee1.AddScore(1); emploee1.AddScore(8); emploee1.AddScore(6); emploee1.AddScore(7);
emploee2.AddScore(4); emploee2.AddScore(1); emploee2.AddScore(8); emploee2.AddScore(9); emploee2.AddScore(9);
emploee3.AddScore(9); emploee3.AddScore(9); emploee3.AddScore(7); emploee3.AddScore(8); emploee3.AddScore(4);

var result1 = emploee1.Result;
var result2 = emploee2.Result;
var result3 = emploee3.Result;


Console.WriteLine($"{emploee1.Name} {result1}    {emploee2.Name} {result2}     {emploee3.Name} {result3}");




