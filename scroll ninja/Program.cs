using System;
using System.Linq;
using System.Collections.Generic;

namespace scroll_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int toDo;
            int toAdd;
            int qNum;
            string scrAddName;
            string carian;
            Console.WriteLine("Scroll to learn list: ");
            List<string> scrolls = new List<string>() { "","Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (true)
            {
                for (i = 1; i < scrolls.Count; i++)
                {
                    Console.Write("Scroll {0} : ", i);
                    Console.WriteLine(scrolls[i]);
                }
                Console.Write("\n");
                Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll\nChoose what to do:");
                toDo = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                if (toDo == 1)
                {
                    Console.WriteLine("Scroll to learn list: ");
                    for (i = 1; i < scrolls.Count; i++)
                    {
                        Console.Write("Scroll {0} : ", i);
                        Console.WriteLine(scrolls[i]);
                    }
                    Console.Write("\n");
                    Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll\nChoose what to do:");
                    toDo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }
                if (toDo == 2)
                {
                    Console.Write("How many scroll to add: ");
                    toAdd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("In what number of queue: ");
                    qNum = Convert.ToInt32(Console.ReadLine());
                    for (i = 1; i < toAdd + 1; i++)
                    {
                        Console.Write("Scroll {0} name: ", i);
                        scrAddName = Console.ReadLine();
                        string items = string.Join(Environment.NewLine, scrAddName);
                        scrolls.Insert(qNum, items);
                    }


                    Console.Write("\n");
                    for (i = 1; i < scrolls.Count; i++)
                    {
                        Console.Write("Scroll {0} : ", i);
                        Console.WriteLine(scrolls[i]);
                    }
                    Console.Write("\n");
                    Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll\nChoose what to do:");
                    toDo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }
                if (toDo == 3)
                {
                    Console.Write("Insert Scroll Name: ");
                    carian = Console.ReadLine();

                    if (scrolls.Contains(carian, StringComparer.OrdinalIgnoreCase))
                    {
                        carian = carian.ToLowerInvariant();
                        scrolls = scrolls.ConvertAll(x => x.ToLowerInvariant());
                        int nomorscr = scrolls.IndexOf(carian);
                        Console.WriteLine($"Book Found. Queue number: {nomorscr}");
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    }
                    Console.Write("\n");
                    Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll\nChoose what to do:");
                    toDo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }
                if (toDo == 4)
                {
                    Console.Write("Remove from list by scroll name? (y/n) : ");
                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {
                        Console.Write("Insert Scroll Name: ");
                        carian = Console.ReadLine();
                        carian = carian.ToLowerInvariant();
                        scrolls = scrolls.ConvertAll(x => x.ToLowerInvariant());
                        for (i = 0; i < scrolls.Count; i++)
                        {
                            if (carian == scrolls[i])
                            {
                                scrolls.Remove(carian);
                            }
                            else
                            {
                                Console.Write("Book not found");
                            }
                        }
                    }
                    else if (yn == "n")
                    {
                        Console.Write("Input scroll Q: ");
                        int scrollQ = Convert.ToInt32(Console.ReadLine());
                        while (scrollQ > scrolls.Count)
                        {
                            Console.Write("Queue not found. insert scroll Q:");
                            scrollQ = Convert.ToInt32(Console.ReadLine());
                        }
                        scrolls.RemoveAt(scrollQ - 1);
                        Console.Write("Book Removed");
                        Console.Write("\n");
                        Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll\nChoose what to do:");
                        toDo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write("Wrong Sellection. Choose again: ");
                        yn = Console.ReadLine();
                    }
                }
            }
        }
    }
}
