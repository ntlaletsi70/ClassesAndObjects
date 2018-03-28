using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
   public class Student : Person,IID
    {
        private Subjects subjects;
        private string firstname;
        private string lastname;

        public Student() : base()
        {

        }

        public Student(string ID, string firstname, string lastname) : base(ID,firstname,lastname)
        {
            subjects = new Subjects();
            this.ID = ID;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public int AddSubject(Subject newSubject)
        {
            int returnValue = subjects.Add(newSubject);
            return returnValue;
        }


        public int Remove(string subjectCode)
        {
            int returnValue = subjects.Remove(subjectCode);
            return returnValue;
        }


        public new  string FirstName { get; set; }

        public new  string LastName { get; set; }

    }
}
