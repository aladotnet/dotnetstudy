
using System.ComponentModel.DataAnnotations;
using DefaultNamespace;
int i = 0000001;
creatToDo creat = new creatToDo();
Console.WriteLine("um eine to do zu erstelen drücke Enter\n");

ConsoleKeyInfo keyInfo = Console.ReadKey();


if (keyInfo.Key == ConsoleKey.Enter)
    do
{
    Console.WriteLine("Titel:");
    creat.Title = Console.ReadLine();
    Console.WriteLine("Description:");
    creat.Description = Console.ReadLine();
    Console.WriteLine("kategorie:");
    creat.category = Console.ReadLine();
    creat.Id = i+10;

    Console.WriteLine("\n" + creat.Title + "\n"
                      + creat.Description + "\n"
                      + creat.category + "\n"
                      + creat.Id);
    Console.WriteLine("\nmöchtest du kein weiters machen drücke enter");
    keyInfo = Console.ReadKey();
}while (keyInfo.Key != ConsoleKey.Enter);
