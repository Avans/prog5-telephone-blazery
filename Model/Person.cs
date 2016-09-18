using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Person
    {
        public String FirstName { get; set; }
        public String LastName
        {
            get;

            set;
        }
        public Int32 TelephoneNumber
        {
            get;

            set;
        }
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
