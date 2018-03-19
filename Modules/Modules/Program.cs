using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    class Program
    {
        static int number;
        const int QUIT = -1;
        static int sum = 0;

        static void HouseKeeping()
        {
            Console.Write("Enter a number or " + QUIT + " to quit: ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        static void DetailLoop()
        {
           
            sum = sum + number;
            HouseKeeping();
          
        }

        static void EndOFJob()
        {
            //Console.WriteLine($"Sum is all values: {sum}");
            Console.WriteLine("Sum is all values: {0}",sum);
        }

        static void Main(string[] args)
        {

            HouseKeeping();

            //loop control variable
            //initialize
            //test
            //alter

            while (number != QUIT)
            {
                //true
                DetailLoop();
            }
            //false

            EndOFJob();
        }
    }
}
