using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
   public class Subjects : DictionaryBase
    {
        public int Add(Subject newSubject)
        {
            int returnVlaue = -2;

            if (newSubject != null)
            {
                returnVlaue = 0;
                Dictionary.Add(newSubject.Code, newSubject);
            }
            else
            {
                if (Dictionary.Contains(newSubject))
                {
                    returnVlaue = -1;
                }
                else
                {

                }
            }
            
            return returnVlaue;
        }
    }
}
