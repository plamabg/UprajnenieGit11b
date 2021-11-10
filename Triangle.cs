using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UprajnenieGit11b
{
    class Triangle
    {
        private int a, b, c;
        public Triangle()
        {
        }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Display()
        {
            Console.WriteLine(a+" "+b+" "+c);
        }
    }
}
