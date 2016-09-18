using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Person
    {
        private String FirstName;
        private String LastName;
        private Int32 TelephoneNumber;
       public String FullName
        {
            get
            {
                return FirstName + " " +  LastName;
            }
        }


      public Person(String FirstName, String LastName)
       {
           this.FirstName = FirstName;
           this.LastName = LastName;
       }
    }
}
