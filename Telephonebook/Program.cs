using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using View;



namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleView view = new ConsoleView();
            Telephonebook book = new Telephonebook();

            List<Person> lijst = new List<Person>();
            String tekst = "" ;

            book.ShowAll(out tekst, out lijst);
            view.Show(tekst, lijst);
            book.FirstNameStartsWith('P', out tekst, out lijst);
            view.Show(tekst, lijst);
            book.LastNameLength(5, out tekst, out lijst);
            view.Show(tekst, lijst);
            book.SortLastNameLength(out tekst, out lijst);
            view.Show(tekst, lijst);

            // lelijk maar leerzaam
            view.Show("Amount of people: " + book.AmountOfPeople, new List<Person>());

            Console.Read();



        }
    }
}
