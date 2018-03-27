using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
     
            //class name     : Program
           //purpose        : It uses main method to test applications made in classes and implement classes
            //Re-use         : none
            //input          : none
            //Output         : string
            static Person p1 = new Person("9999999", "Kruger", "Pieter");
            static Subject s1 = new Subject("SSD216C", "Software Development II", 100);
            static Subject s2 = new Subject("OPG20BB", "Software Development II", 80);
            static Subject s3 = new Subject("SOD216C", "Software Development II", 90);
            static ArrayList subjects = new ArrayList();
            static void Main(string[] args)
            {
                //Method name    : void Main(string[] args)
                //purpose        : sets the values for the person,interface and subject
                //                 then test the program with the assigned values.
                //Re-use         : Person;Subject;ListEmptyException;IID;
                //input          : string[] args
                //Output         : none

                Subject s4;
                Console.WriteLine(p1);
                PrintObjects();
                subjects.Add(s1);
                subjects.Add(s2);
                subjects.Add(s3);
                PrintArrayList();

                s1.ID = "aaaaaa";
                PrintObjects();
                PrintArrayList();
                //s4 = new Subject("AAA", "Sub AAA");
               // Console.WriteLine(s4);
            }//end main
        public static void PrintObjects()
        {
            //Method name    : void PrintObjects()
            //purpose        : to display strings
            //Re-use         : none
            //input          : none
            //Output         : objects
            //                 s1
            //                 s2
            //                 s3
            Console.WriteLine("--------------------");
            Console.WriteLine("Objects");
            Console.WriteLine("--------------------");
            Console.WriteLine("\t" + s1);
            Console.WriteLine("\t" + s2);
            Console.WriteLine("\t" + s3);
        }//end PrintObjects 
        public static void PrintArrayList()
        {
            //Method name    : void PrintObjects()
            //purpose        : to display strings
            //Re-use         : none
            //input          : none
            //Output         : ArrayList
            //                 subRef
            Console.WriteLine("--------------------");
            Console.WriteLine("ArrayList");
            Console.WriteLine("--------------------");
            foreach (Subject subRef in subjects)
            {
                Console.WriteLine("\t" + subRef);
            }//end foreach
        }//end PrintArrayList
    }//end class Program
}
   
