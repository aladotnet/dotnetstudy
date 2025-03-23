using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using DefaultNamespace;

int startindex = 1;
List<string> ToDo = new List<string>();
ToDo creat = new ToDo();

ConsoleKeyInfo keyInfo = Console.ReadKey();

while (keyInfo.Key == ConsoleKey.D1)
{
    Console.WriteLine("\nTitel:");
    creat.Title = Console.ReadLine();
    Console.WriteLine("Description:");
    creat.Description = Console.ReadLine();
    Console.WriteLine("kategorie:");
    creat.category = Console.ReadLine();
    creat.Id = startindex + 10;

    ToDo.Add(creat.Title + creat.Description + creat.category + creat.Id);

    Console.WriteLine("\n" + creat.Title + "\n"
                      + creat.Description + "\n"
                      + creat.category + "\n"
                      + creat.Id);
    Console.WriteLine("\nmöchtest du kein weiters machen drücke enter");
    keyInfo = Console.ReadKey();
}        