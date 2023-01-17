using System;

string name = "Anna";
char sex = 'K';
int age = 28;

if(sex == 'M')

    if(age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

else

    if (age < 30)
    {
        Console.WriteLine("Kobieta, poniżej 30 lat");
    }

