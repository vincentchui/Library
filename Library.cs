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

        public void searchBySubject()
        {
            string search;

            Console.Write("\nWhat subject to search for? ");
            search = Console.ReadLine();

            if(subject.Contains(search))
            {

            }
        }
    }
}
