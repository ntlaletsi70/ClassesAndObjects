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
            int returnValue = -2;

            if (newSubject != null)
            {
                returnValue = 0;
                Dictionary.Add(newSubject.Code, newSubject);
            }
            else
            {
                if (Dictionary.Contains(newSubject))
                {
                    returnValue = -1;
                }
                else
                {

                }
            }

            return returnValue;
        }

        public int Remove(string subjectCode)
        {
            int returnValue = 0;

            if (Dictionary.Count <= 0)
            {
                returnValue = -1;
                throw new ListEmptyException("Subject collection is empty, nothing to remove");
            }
            else
            {
                if (Dictionary.Contains(subjectCode))
                {
                    Dictionary.Remove(subjectCode);
                }
                    
            }

            return returnValue;
        }
    }
}
