using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        private string[] title;
        private string[] author;
        private string[] lccn;
        private string[] subject;
        private string[] publisher;
        private string[] year;
        private bool[] circulation;

        public void menu()
        {
            string choice, search;

            title = new string[10]
            { "C# Programming", "Unity", "Unreal",
                "Swift Programming", "C Programming",
                "C++ Programming", "JavaScript Programming",
                "Photoshop", "Premiere", "Aftereffects"
            };

            author = new string[10]
    { "Microsoft", "Unity", "Epic", "Apple",
                "GNU", "EFF", "Oracle", "Adobe", "Adobe",
                "Adobe"
    };

            lccn = new string[10]
    { "4123", "4321", "5427", "8653", "9764", "0542",
                "5317", "5390", "1486", "1670"
    };

            subject = new string[10]
    { "Programming", "Graphics", "Graphics",
            "Programming", "Programming", "Programming",
            "Programming", "Editing", "Editing", "Editing"
    };

            publisher = new string[10]
    { "Microsoft", "Unity", "Epic", "Apple",
            "GNU", "EFF", "Oracle", "Adobe", "Adobe", "Adobe"
    };

            year = new string[10]
            { "1992", "2014", "2015", "2015", "1986",
                "1998", "2000", "2011", "2012", "2013"
            };

            circulation = new bool[10]
            { true, true, true, true, false, false, false,
                true, true, true
            };

            Console.WriteLine("\nWritten by Vincent Chui" +
                    "\nCIS 23 Fall 2015 BCC");
            do
            {
                Console.Write("\nList Books" +
                    "\nSearch Subject" +
                    "\nQuit" +
                    "\nEnter your choice: ");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "list books":
                        for(int i = 0; i < title.Length; i++)
                        {
                            ToString(title[i], author[i], lccn[i],
                                subject[i], publisher[i], circulation[i]);
                        }
                        break;
                    case "search subject":

                        Console.Write("\nWhat is the subject? ");
                        search = Console.ReadLine();

                        searchSubject(title, author, lccn, subject,
                              publisher, circulation, search);
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

        public void searchSubject(string[] title, string[] author,
            string[] lccn, string[] subject, string[] publisher,
            bool[] circulation, string search)
        {
            int[] index = new int[10];

            for (int i = 0; i < subject.Length; i++)
            {
                if (search == subject[i])
                {
                    ToString(title[i], author[i],
                        lccn[i], subject[i], publisher[i],
                        circulation[i]);
                }
            }
        }

        public void ToString(string title, string author,
            string lccn, string subject, string publisher,
            bool circulation)
        {
            Console.WriteLine("\nTITLE: " + title +
                "\nAUTHOR: " + author +
                "\nLCCN: " + lccn +
                "\nSUBJECT: " + subject +
                "\nPUBLISHER: " + publisher +
                "\nCIRCULATION: " + circulation);
        }
    }
}
/*OUTPUT

Written by Vincent Chui
CIS 23 Fall 2015 BCC

List Books
Search Subject
Quit
Enter your choice: list books

TITLE: C# Programming
AUTHOR: Microsoft
LCCN: 4123
SUBJECT: Programming
PUBLISHER: Microsoft
CIRCULATION: True

TITLE: Unity
AUTHOR: Unity
LCCN: 4321
SUBJECT: Graphics
PUBLISHER: Unity
CIRCULATION: True

TITLE: Unreal
AUTHOR: Epic
LCCN: 5427
SUBJECT: Graphics
PUBLISHER: Epic
CIRCULATION: True

TITLE: Swift Programming
AUTHOR: Apple
LCCN: 8653
SUBJECT: Programming
PUBLISHER: Apple
CIRCULATION: True

TITLE: C Programming
AUTHOR: GNU
LCCN: 9764
SUBJECT: Programming
PUBLISHER: GNU
CIRCULATION: False

TITLE: C++ Programming
AUTHOR: EFF
LCCN: 0542
SUBJECT: Programming
PUBLISHER: EFF
CIRCULATION: False

TITLE: JavaScript Programming
AUTHOR: Oracle
LCCN: 5317
SUBJECT: Programming
PUBLISHER: Oracle
CIRCULATION: False

TITLE: Photoshop
AUTHOR: Adobe
LCCN: 5390
SUBJECT: Editing
PUBLISHER: Adobe
CIRCULATION: True

TITLE: Premiere
AUTHOR: Adobe
LCCN: 1486
SUBJECT: Editing
PUBLISHER: Adobe
CIRCULATION: True

TITLE: Aftereffects
AUTHOR: Adobe
LCCN: 1670
SUBJECT: Editing
PUBLISHER: Adobe
CIRCULATION: True

List Books
Search Subject
Quit
Enter your choice: search subject

What is the subject? Editing

TITLE: Photoshop
AUTHOR: Adobe
LCCN: 5390
SUBJECT: Editing
PUBLISHER: Adobe
CIRCULATION: True

TITLE: Premiere
AUTHOR: Adobe
LCCN: 1486
SUBJECT: Editing
PUBLISHER: Adobe
CIRCULATION: True

TITLE: Aftereffects
AUTHOR: Adobe
LCCN: 1670
SUBJECT: Editing
PUBLISHER: Adobe
CIRCULATION: True

List Books
Search Subject
Quit
Enter your choice: search subject

What is the subject? Graphics

TITLE: Unity
AUTHOR: Unity
LCCN: 4321
SUBJECT: Graphics
PUBLISHER: Unity
CIRCULATION: True

TITLE: Unreal
AUTHOR: Epic
LCCN: 5427
SUBJECT: Graphics
PUBLISHER: Epic
CIRCULATION: True

List Books
Search Subject
Quit
Enter your choice: search subject

What is the subject? Programming

TITLE: C# Programming
AUTHOR: Microsoft
LCCN: 4123
SUBJECT: Programming
PUBLISHER: Microsoft
CIRCULATION: True

TITLE: Swift Programming
AUTHOR: Apple
LCCN: 8653
SUBJECT: Programming
PUBLISHER: Apple
CIRCULATION: True

TITLE: C Programming
AUTHOR: GNU
LCCN: 9764
SUBJECT: Programming
PUBLISHER: GNU
CIRCULATION: False

TITLE: C++ Programming
AUTHOR: EFF
LCCN: 0542
SUBJECT: Programming
PUBLISHER: EFF
CIRCULATION: False

TITLE: JavaScript Programming
AUTHOR: Oracle
LCCN: 5317
SUBJECT: Programming
PUBLISHER: Oracle
CIRCULATION: False

List Books
Search Subject
Quit
Enter your choice: quit

Goodbye
Press any key to continue . . .
*/
