using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasprog20181116
{
    class Program
    {
        //globális változók
       static List<string> todo = new List<string>();
       static List<bool> completed = new List<bool>();
        static void DisplayMenu()
        {
            //Metódusok
            Console.WriteLine("A - add new item: új elem hozzáadása a listához");
            Console.WriteLine("C - complete an item: meglévő elemet teljesítettük, tehát törlődhet a listából");
            Console.WriteLine("S - show all items: az összes elem kiírása a képernyőre");
            Console.WriteLine("Esc - exit");
        }
        static void AddToList(string stuff)
        {
            todo.Add(stuff);
            completed.Add(false);
        }

        static bool DeleteFromList(int index)
        {
            if(index < 1 || index > completed.Count)
                return false;

            completed[index - 1] = true;
            return true;
            
        }
        static void Main(string[] args)
        {
            //lokális változók
            ConsoleKey key;
            do
            {
                DisplayMenu();
                key = Console.ReadKey(true).Key;     //.Key megadja, hogy mit nyomott le a felhasználó
                Console.Clear();

                switch (key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Milyen teendőt adjak a listához?");
                        AddToList(Console.ReadLine());
                        break;

                    case ConsoleKey.C:
                        int torlendo;
                        do
                        {
                            Console.WriteLine("Hanyadik elemet törölnéd?");
                        } while (!int.TryParse(Console.ReadLine(), out torlendo) || torlendo < 1 || torlendo > todo.Count);
                      
                       // todo.RemoveAt(torlendo - 1);

                       // completed[torlendo - 1] = true;

                    if(DeleteFromList(torlendo))
                        Console.WriteLine("Sikerült a törlés!");
                    else
                        Console.WriteLine("Nem sikerült a törlés");

                        break;

                    case ConsoleKey.S:
                        
                            for (int i = 0; i < todo.Count; i++)
                            {
                                if (completed[i])
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                    Console.WriteLine("{0} - {1}", i + 1, todo[i]);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                            }
                           
                        break;

                    case ConsoleKey.Escape:
                        break;

                    default:
                        Console.WriteLine("Rossz választás.");
                        break;
                }


            } while (key != ConsoleKey.Escape);


           

        }
    }
}
/*Írd programot, mellyel egy to-do listát lehet összeállítani és menedzselni!

A program írjon ki egy menüt:

A - add new item: új elem hozzáadása a listához
C - complete an item: meglévő elemet teljesítettük, tehát törlődhet a listából
S - show all items: az összes elem kiírása a képernyőre
X - exit
A program minden választott művelet elvégzése után törölje le képernyőt és jelenítse meg újra a menüt, amíg a felhasználó X-szel ki nem lép.

Továbbfejlesztés: A teljesített elemeket ne törlődjük fizikailag a listából, hanem jelöljük meg őket, mint már teljesített elemeket. Ezeket a képernyőn más színnel jelenítsük meg, mint a még aktív elemeket.*/