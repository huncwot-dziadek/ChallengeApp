using System;

string name = "Anna";
char sex = 'K';
int age = 19;

if(sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

else if ((age < 30) && (sex == 'K'))
{
    Console.WriteLine("Kobieta, poniżej 30 lat");
}

