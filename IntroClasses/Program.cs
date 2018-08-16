using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int y = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine(ClassWithMethods.Add10(y));
            Console.WriteLine(ClassWithMethods.Minus10(y));
            Console.WriteLine(ClassWithMethods.Mult10(y));
            Console.ReadLine();
        }  
    }
}
