using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Library
{
    class Library
    {
        ArrayList title = new ArrayList();
        ArrayList author = new ArrayList();
        ArrayList lccn = new ArrayList();
        ArrayList subject = new ArrayList();
        ArrayList publisher = new ArrayList();
        ArrayList year = new ArrayList();
        ArrayList circulation = new ArrayList();

        public void addBook()
        {
            Console.Write("\nWhat is the title? ");
            title.Add(Console.ReadLine());

            Console.Write("\nWhat is the author? ");
            author.Add(Console.ReadLine());

            Console.Write("\nWhat is the lccn? ");
            lccn.Add(Console.ReadLine());

            Console.Write("\nWhat is the subject? ");
            subject.Add(Console.ReadLine());

            Console.Write("\nWhat is the publisher? ");
            publisher.Add(Console.ReadLine());

            Console.Write("\nWhat is the year? ");
            year.Add(Console.ReadLine());

            do
            {
                Console.Write("\nIs this in circulation? (Yes/No) ");
                circulation.Add(Console.ReadLine().ToLower());

                if((Console.ReadLine() != "yes") || (Console.ReadLine() != "no"))
                {
                    Console.WriteLine("\nINVALID INPUT");
                }
            } while ((Console.ReadLine() != "yes") || (Console.ReadLine() != "no"));
        }

        public void initArray()
        {
            title.Add("C# Programming");
            author.Add("Microsoft");
            lccn.Add("0001");
            subject.Add("Technology");
            publisher.Add("Microsoft");
            year.Add("2015");
            circulation.Add("Yes");

            title.Add("C# Programming 2");
            author.Add("Microsoft");
            lccn.Add("0002");
            subject.Add("Technology");
            publisher.Add("Microsoft");
            year.Add("2015");
            circulation.Add("No");

            title.Add("C# Unity");
            author.Add("Microsoft");
            lccn.Add("0001");
            subject.Add("Technology");
            publisher.Add("Microsoft");
            year.Add("2015");
            circulation.Add("Yes");
        }

        public void searchBySubject()
        {
            string search;

            Console.Write("\nWhat subject to search for? ");
            search = Console.ReadLine();

            if(subject.Contains(search))
            {
                Console.WriteLine();
            }
        }

        public void menu()
        {
            string choice;

            initArray();

            do
            {
                Console.Write("\nSearch by subject" +
                    "\nAdd Book" +
                    "\nQuit");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "search by subject":
                        searchBySubject();
                        break;
                    case "quit":
                        Console.WriteLine("\nGoodbye");
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break;
                }
            } while (choice != "quit");
        }

    }
}
