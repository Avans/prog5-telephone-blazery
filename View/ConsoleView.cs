using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;



namespace View
{
    public class ConsoleView
    {
        // alleen de view het scherm laten regelen.
       public void Show( String tekst, List<Person> lijst)
        {
            Console.WriteLine(tekst);
            int x = 0;
            foreach (Person p in lijst)
            {
                Console.WriteLine(x + ". " + p.FullName);
                x++;
            }
            Console.WriteLine("");
        }
      
    }
}
