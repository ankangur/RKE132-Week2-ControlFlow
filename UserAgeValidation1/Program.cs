//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus on vähem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul kuvatakse konsoolis:
//"Welcome to Instagram"
Console.WriteLine("Enter your age:");

// string userAge = Console.ReadLine(); - sõne "13" võtab rohkem ruumi (salvestatakse heap-i), kui number 13 (salvestatakse stack-i)
int userAge = Int32.Parse(Console.ReadLine()); //parsime stringi numbriks int tüüpi muutuja sisse

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");
}

