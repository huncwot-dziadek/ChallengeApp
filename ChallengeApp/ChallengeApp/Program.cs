using System; using System.Globalization;

List<string> Grupa = new List<string>();
Grupa.Add("Zenon"); Grupa.Add("Bruno"); Grupa.Add("Klaudia"); Grupa.Add("Klaudia"); Grupa.Add("Zenon");
Grupa.Add("Klaudia"); Grupa.Add("Zenon"); Grupa.Add("Sławomir"); Grupa.Add("Ananiasz"); Grupa.Add("Klaudia");
Grupa.Add("Zenon"); Grupa.Add("Zenon"); Grupa.Add("Ananiasz"); Grupa.Add("Mietek"); Grupa.Add("Bruno");
Grupa.Add("Zenon"); Grupa.Add("Klaudia"); Grupa.Add("Wanda"); Grupa.Add("Mietek"); Grupa.Add("Mietek");

List<int> ileRazy = new List<int>();
int NumbRepet = 0; int n = 0;

for (int i = 0; i <= Grupa.Count - 1; i++)
{
    for (var j = Grupa.Count - 1; j >= n + 1; j--)
    {
        if (Grupa[i] == Grupa[j])
        {
            Grupa.RemoveAt(j);
            NumbRepet = NumbRepet + 1;
        }
    }
    n = n + 1;
    ileRazy.Add(NumbRepet + 1); NumbRepet = 0;
}

for (int k = 0; k < ileRazy.Count; k++)
{
    Console.WriteLine($"{Grupa[k]}:  {ileRazy[k]}");
}
