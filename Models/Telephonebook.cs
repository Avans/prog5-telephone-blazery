using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Telephonebook
    {
       private List<Person> book = new List<Person>();

        public int AmountOfPeople
        {
            get{
             return book.Count ;
            }
        }

     public Telephonebook()
       {
           book.Add(new Person("John", "Snow"));
           book.Add(new Person("Perry", "White"));
           book.Add(new Person("Rick", "Senchez"));
           book.Add(new Person("Naruto", "Asian"));
           book.Add(new Person("Peppie", "Coke"));
           book.Add(new Person("Fiora", "OP"));
           book.Add(new Person("Morty", "Senchez"));
           book.Add(new Person("Light", "Yagami"));
           book.Add(new Person("Eduward", "Elrich"));
           book.Add(new Person("John", "Cena"));
       }


       public void ShowAll()
       {
           IEnumerable<Person> result = from p in book
                                orderby p.FullName
                                select p ;
           List<Person> test = book.Where(p => p.FullName == "test").OrderBy(p=> p.FullName.Split('-')[1]).Select(p => p).ToList() ;



           Console.WriteLine("### Sorteren op achternaam ###" );
           ShowList(test);

       }

       public void FirstNameStartsWith(char letter)
       {

       }
       public void LastNameLength(int number)
       {

       }
       public void SortLastNameLength()
       {

       }
       private void ShowList(List<Person> lijst)
       {
           int x = 0;
           foreach (Person p in lijst)
           {
               Console.WriteLine( x + ". " + p.FullName);
               x++;
           }
       }

    }
}
