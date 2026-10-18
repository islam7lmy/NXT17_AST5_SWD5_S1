using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    class Parent
    {
        public int A { get; set; }

        public Parent(int _a)
        {
            A = _a;
        }

        public void ShowRole()
        {
            Console.WriteLine("Hi I am Parent");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Parent : A = {A}");
        }
    }
}
