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

            if (!(newSubject == null) && (!Contains(newSubject.Code)))
            {
                returnValue = 0;
                Dictionary.Add(newSubject.Code, newSubject);
            }
            else
            {
                returnValue = -1;              
            }

            return returnValue;
        }


    public int Remove(string subjectCode)
        {
            int returnValue = 0;

            if (Dictionary.Count <= 0)
            {
              
                throw new ListEmptyException("Subject collection is empty, nothing to remove");
            }
            else
            {
                if (Contains(subjectCode))
                {
                    returnValue = 0;
                    Dictionary.Remove(subjectCode);
                }
                else
                {
                    returnValue = -1;
                }
                    
            }

            return returnValue;
        }

        public Subject this[int subjectIndex]
        {
            get
            {
                return (Subject)Dictionary[subjectIndex];
            }
            set
            {
                Dictionary[subjectIndex] = value;
            }
        }



   

    public bool Contains(string newSubject)
        {
            bool status = false;

            if(Dictionary.Contains(newSubject))
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

    }
}
