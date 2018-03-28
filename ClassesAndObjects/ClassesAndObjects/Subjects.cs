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
                if (Contains(newSubject.Code))
                {
                    returnValue = -1;
                }
                else
                {

                }
            }

            return returnValue;
        }



        public new IEnumerator GetEnumerator()
        {
                foreach (object subject in Dictionary.Values)
                yield return (Subject)subject;
        }


        //public string this[int index, string val]
        //{
        //    get
        //    {
        //        string temp;
        //        if (index > 0)
                  
        //        return (Subject)[index];
        //    }
        //    set
        //    {
        //        if (index > 1)

        //        testdctnry.Add(index, val);
        //    }
        //}

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
                if (Contains(subjectCode))
                {
                    Dictionary.Remove(subjectCode);
                }
                    
            }

            return returnValue;
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
