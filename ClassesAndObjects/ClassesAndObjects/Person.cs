using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person : IID
    {
        private string firstname;
        private string lastname;

        public Person()
        {
        }


        public Person(string ID, string firstname, string lastname)
        {
            this.ID = ID;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string ID { get; set; }


        public override string ToString()
        {
            return ID + ": " + FirstName + "," + LastName
                + ".";

        }
    }
}
