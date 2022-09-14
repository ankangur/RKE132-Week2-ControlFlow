// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Annika!");

//rakendus küsib kasutajal valida sugu (m/f)
//rakendus küsib kasutajal sisestada perekonnanime
//Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / Welcome, Ms. [kasutaja perekonnanimi]"

//Console.WriteLine($"Welcome, {userGender}");

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Console.ReadlIne loeb konsloolist maha andmeid string e sõne formaadis, Char muudab selle sõne väiksemaks sümboliks

Console.WriteLine("Please, enter your last name");
string userLastName = Console.ReadLine(); //küsin kindlasti enne if lauseid

if(userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}








