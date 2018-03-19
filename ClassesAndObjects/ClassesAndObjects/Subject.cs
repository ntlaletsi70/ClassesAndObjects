using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Subject : IID
    {
        private string code;
        private int grade;

        public string Code { get; set; }
        public int Grade { get; set; }


        public Subject()
        {

        }

        public Subject(string ID, string code, int grade)
        {
            this.ID = ID;
            this.Code = code;
            this.Grade = grade;
        }


        public string ID { get; set; }

        public override string ToString()
        {
            return ID + ": " + Code + "(" + grade + ")";
        }
    }
}
