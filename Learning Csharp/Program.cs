using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         INT X;
         INT Y;

         X=3 ;
         Y=X+5;
         CONSOLE.WRITELINE(Y); */
         

         // Print Name ,Defining Strings and Concatenarion
         Console.WriteLine("What is your Name?");
         Console.Write("Type your First Name: ");
         string FirstName;
         FirstName = Console.ReadLine();
         
         string LastName ;
         Console.Write("Type your Last Name: ");
         LastName = Console.ReadLine();

         Console.WriteLine("Hello, " + FirstName + " " + LastName);
            Console.ReadLine();

        }

    }
}
