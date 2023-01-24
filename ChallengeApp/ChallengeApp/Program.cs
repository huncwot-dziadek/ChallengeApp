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

emploee2.AddScore(4);
emploee2.AddScore(1);
emploee2.AddScore(8);
emploee2.AddScore(9);
emploee2.AddScore(10);

emploee3.AddScore(9);
emploee3.AddScore(9);
emploee3.AddScore(9);
emploee3.AddScore(3);
emploee3.AddScore(3);


List<Emploee> emploeeTable = new List<Emploee>()
{
    emploee1, emploee2, emploee3
};

//List<Emploee> emploeeResults = new List<Emploee>()
//{
//    emploee1.Result, emploee2.Result, emploee3.Result
//};

int[] tableResults = new int[3];
for (int i = 0; i < 3; i++)
{
    tableResults[i] = 0;
}
int j = 0;

foreach (var emploee in emploeeTable)
{
    tableResults[j] = tableResults[j] + emploee.Result;
    emploee.Result = 0;

    Console.WriteLine(tableResults[j]);


    //Console.WriteLine(tableResults[i]);
}

//int maxResult = -1;
//Emploee emploeeWithMaxValue = null;




//Console.WriteLine(emploeeWithMaxValue);

//List<int> TemporaryList = new List<int>();

//TemporaryList.Add(emploee1.Result);
//TemporaryList.Add(emploee2.Result);
//TemporaryList.Add(emploee3.Result);

//var max = TemporaryList.Max(); 
//var indexMax = TemporaryList.IndexOf(max);
//var min = TemporaryList.Min();
//var indexMin = TemporaryList.IndexOf(min);

//if (emploee1.Result == emploee2.Result && emploee1.Result == emploee3.Result)
//{
//    Console.WriteLine($"Wszyscy pracownicy osiągnęli ten sam wynik, który wynosi {max}. Są to:");
//    Console.WriteLine(emploee1.Name + "  " + emploee1.Surname + " lat " + emploee1.Years);
//    Console.WriteLine(emploee2.Name + "  " + emploee2.Surname + " lat " + emploee2.Years);
//    Console.WriteLine(emploee3.Name + "  " + emploee3.Surname + " lat " + emploee3.Years);
//    Console.WriteLine();
//}


////else if (emploee1.Result != emploee2.Result && emploee1.Result != emploee3.Result && emploee2.Result != emploee3.Result)
////{
////    Console.WriteLine("Pracownikiem, który uzyskał najwięcej punktów jest:");
////    //Console.WriteLine(EmploeeTable[indexMax]);
////    Console.WriteLine();


////}
//string wiersz1 = "FFF";

//Console.WriteLine(emploeeTable[1]);
//Console.WriteLine(wiersz1);

////Console.WriteLine(EmploeeTable.ElementAt(1));


//Console.WriteLine(max);
//Console.WriteLine(indexMax);
//Console.WriteLine(min);
//Console.WriteLine(indexMin);





////for (int i = 0; i <= WorkList1.Count; i++)





//foreach (var ddd in TemporaryList)
//{
//    Console.WriteLine(ddd);
//}
