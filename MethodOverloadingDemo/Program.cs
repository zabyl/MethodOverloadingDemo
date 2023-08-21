using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 9764;

            Methods method = new Methods();
            method.PrintConsole(num);

            Console.ReadLine();
        }
    }

    class Methods
    {
        public void PrintConsole(string data)
        {
            Console.WriteLine(data);
        }

        public void PrintConsole(int data)
        {
            Console.WriteLine(data);
        }
    }
}
