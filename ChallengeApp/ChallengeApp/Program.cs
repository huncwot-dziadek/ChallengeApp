using System;

string name = "Krzysztof";
char sex = 'M';
int age = 55;

if((sex == 'K') && (age < 30)) 
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if((name == "Ewa") && (age == 33))
{
    Console.WriteLine("Ewa, lat 33");
}

if ((sex == 'M') && (age < 18))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

else
{
    Console.WriteLine("Ktoś inny");
}
