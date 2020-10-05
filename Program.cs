using System;

namespace kelly_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            LinkedList ll = new LinkedList();

            while (input != "6")
            {
                Console.WriteLine("\nEnter an option from the menu:\n\n1. Show Head\n2. Add Item\n3. Remove Item\n4. Search for item\n5. Print\n6. Exit\n");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine(ll.GetFirst());
                }
                if (input == "2")
                {
                    Console.WriteLine("Add an item:\n");
                    string add = Console.ReadLine();
                    Console.WriteLine("Add an item to the front or back: (F=front/B=back)");
                    string choice = Console.ReadLine().ToUpper();
                    while (!choice.Equals("F") && !choice.Equals("B"))
                    {
                        Console.WriteLine("Invalid option. Try again.\n");
                        choice = Console.ReadLine().ToUpper();
                    }
                    if (choice.Equals("F"))
                    {
                        ll.AddFirst(add.ToLower());
                    }
                    else
                    {
                        ll.Add(add.ToLower());
                    }
                }
                if (input == "3")
                {
                    Console.WriteLine("Choose an item to remove:\n");
                    string remove = Console.ReadLine();
                    if (ll.Contains(remove.ToLower()) == null)
                    {
                        Console.WriteLine("There is no " + input + " in the list.");
                    }
                    else
                    {
                        ll.Remove(remove.ToLower());
                        Console.WriteLine(remove + " was removed");
                    }
                }
                if (input == "4")
                {
                    Console.WriteLine("Choose an item to search for:\n");
                    string search = Console.ReadLine();
                    if (ll.Contains(search.ToLower()) != null)
                    {
                        Console.WriteLine(search + " appears in the list.");
                    }
                    else
                    {
                        Console.WriteLine(search + " does not appear in the list.");
                    }
                }
                if (input == "5")
                {
                    ll.PrintAllNodes();
                }
            }
        }
    }
}