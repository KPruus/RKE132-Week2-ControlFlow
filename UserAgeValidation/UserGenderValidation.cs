// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida sugu (m/f)
//rakendus küsib kasutajal sisestada perenime
//lähtudes valikust, rakendus tervitab vastavalt:
//"Tervist Härra, [nimi] / Tervist, Preili [nimi]

Console.WriteLine("Please select ur gender (m/f)");

char usergender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string e. sõne formaadis
Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (usergender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (usergender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
