using System;
using System.Globalization;

List<string> Grupa = new List<string>();
Grupa.Add("Zenon"); Grupa.Add("Bruno"); Grupa.Add("Bruno"); Grupa.Add("Klaudia");
Grupa.Add("Wanda"); Grupa.Add("Klaudia"); Grupa.Add("Zenon"); Grupa.Add("Mietek");
Grupa.Add("Ananiasz"); Grupa.Add("Klaudia"); Grupa.Add("Wanda"); Grupa.Add("Zenon");
Grupa.Add("Mietek"); Grupa.Add("Ananiasz"); Grupa.Add("Bruno"); Grupa.Add("Zenon");
Grupa.Add("Klaudia"); Grupa.Add("Klaudia"); Grupa.Add("Mietek"); Grupa.Add("Mietek");

List<int> ileRazy = new List<int>();

int k = 0;  int n = 0;

for (int j = 0; j < Grupa.Count - 1; j++)
{
    for (var i = Grupa.Count - 1; i >= n + 1; i--)
    {
        if (Grupa[j] == Grupa[i])
        {
            Grupa.RemoveAt(i);
            k = k + 1;
        }
    }

    n = n + 1;
    ileRazy.Add(k+1); k = 0;

}

//Console.WriteLine(Grupa.Count);
//Console.WriteLine(k);

//for (int h = 0; h < Grupa.Count; h++)
//{
//    Console.WriteLine(Grupa[h]);
//}

//for (int g = 0; g < ileRazy.Count; g++)
//{
//    Console.WriteLine(ileRazy[g]);
//}

for (int p = 0; p < ileRazy.Count; p++)
{
    Console.WriteLine($"{Grupa[p]}:  {ileRazy[p]}");
}
