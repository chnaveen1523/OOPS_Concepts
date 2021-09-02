using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class TestMemberOverloading
    {
        public static void Main()
        {
            Console.WriteLine(Program.add(12, 23));
            Console.WriteLine(Program.add(12, 23, 25));
        }
    }
}
}