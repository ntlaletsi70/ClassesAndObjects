using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class ListEmptyException : Exception
    {

        public ListEmptyException()
        {

        }

        public ListEmptyException(string message)
        {


            message = "List is Empty";
        }
    }
}
