using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
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

        // experimenteren met out parameters
       public void ShowAll(out String tekst, out List<Person> result)
       {
           result = (from p in book
                      orderby p.LastName
                     select p).ToList();



           tekst = "### Sorteren op achternaam ###" ;

       }

       public void FirstNameStartsWith(char letter, out String tekst, out List<Person> result)
       {
         result = (from p in book
                                  where p.FirstName.ToCharArray()[0] == letter
                                  orderby p.LastName
                                  select p).ToList();




         tekst = "### FirstName begint met " + letter + " ###";
       
       }
       public void LastNameLength(int number, out String tekst, out List<Person> result)
       {
         result = (from p in book
                                  where p.LastName.Length > number
                                  orderby p.LastName
                                  select p).ToList();




         tekst = "### Lastname langer dan " + number + " ###";
          
       }
       public void SortLastNameLength(out String tekst, out List<Person> result)
       {
           result = (from p in book
                                  orderby p.LastName.ToCharArray().Count(), p.FirstName
                                  select p).ToList();




           tekst = "### Sorteen op achternaam lengte ###";
        
       }
      

    }
}
