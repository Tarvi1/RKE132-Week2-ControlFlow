// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajalt sisestada tema perekonnamine
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char usergender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõna) formaadis
Console.WriteLine("Please, enter your last name:") ;

string userlastname = Console.ReadLine();

if (usergender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userlastname}!");
}
else if (usergender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userlastname}!");
}
else
{
   Console.WriteLine($"Welcome, {userlastname}!");
}

