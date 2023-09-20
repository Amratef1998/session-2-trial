using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace session_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Variable
            int numvariable01 = 3;
            int numvariable02 = 5;
            double numvariable03 = 4.80;

            // Real number

            #region if and boolian
            //decimal decvar01 = 5;
            //float flovar01 = 2;
            //char my_schoolGrade = 'A';
            //Console.WriteLine(my_schoolGrade);
            //Console.ReadLine();
            //bool fishtasty = false;
            //decimal var02 = 5.25m;
            //bool isfishtasty = false;
            //bool doyoulikeme = true;
            //if (isfishtasty == true)
            //{
            //    console.writeline("happy to hear this");
            //    console.readline();
            //}
            //else
            //{

            //    console.writeline("thanks sir");
            //    console.readline();
            //}
            //Console.WriteLine("was ="+numvariable03);
            //numvariable03 = numvariable01*numvariable02;
            //Console.WriteLine("now is ="+ numvariable03);
            //Console.ReadLine();
            int result =8%2;
            //Console.WriteLine(result);
            //Console.ReadLine();
            //Reminder
            // if (result == 0) {
            //     Console.WriteLine("The number is even");
            // }
            //else
            // {
            //     Console.WriteLine("The Number is odd");
            // }
            //increment
            result++;
            Console.WriteLine(result);
            numvariable01 = numvariable02 + (int)numvariable03;
            Console.WriteLine(numvariable01);

            #endregion













        }
    }
}