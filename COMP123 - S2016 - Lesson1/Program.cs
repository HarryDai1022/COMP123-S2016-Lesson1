using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123___S2016___Lesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            HelloWorldToConsole();
        }

        //This is my HElloWorld method
        //method HelloWorldToConsole
        //return (string) HelloWorldString
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
