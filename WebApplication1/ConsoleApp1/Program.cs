using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 1000; x++)
            {
                WpfLibrary1.Class.writeLog(x.ToString(),1,5, @"E:\");
                Console.WriteLine(x);
            }
        }
    }
}
