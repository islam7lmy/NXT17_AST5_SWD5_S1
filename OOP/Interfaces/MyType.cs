using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.nterfaces
{

    /// interface : is a contract that define a set of 
    /// methods, properties, events, or indexers that a class or struct must implement.

    interface IMytype
    {
        /// What You Can Write Inside The Interface?
        /// method signature
        /// properties signature
        /// indexers signature
        /// events signature
        /// default implementation of methods, properties, events, and indexers (from C# 8.0 onwards)

        /// Default acces modifiers inside the interface is Public
        /// private is not allowed inside the interface

        ///property Signature
        int Salary { get; set; }

        ///method Signature
        void Myfun();

        ///method Signature
        void Myfun2();

        void IPrint()
        {
            Console.WriteLine("Hello I am default Implment");
        }

    }



    ///Salary - 1000
    ///myfun() => "Hello Print"

    internal class MyType : IMytype //=> implmentation
    {
        ///Clr will generate backing field
        //public int Salary { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value <= 2000 ? 2000 : value; }
        }

        public void Myfun()
        {
            Console.WriteLine("Hello");
        }

        public void Myfun2()
        {
            Console.WriteLine($"Hi I am Mytype : salary : {Salary}");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        //public void IPrint()
        //{
        //    Console.WriteLine("Hello I am default Implment");
        //}

    }

    internal class MyTypeV2 : IMytype
    {
        ///Clr will generate backing field
        //public int Salary { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value - 1000; }
        }

        public void Myfun()
        {
            Console.WriteLine("Hello Print");
        }

        public void Myfun2()
        {
            Console.WriteLine($"Hi I am MytypeV2 : salary : {Salary}");
        }

    }

    internal class MyTypeV3 : IMytype
    {
        public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Myfun()
        {
            throw new NotImplementedException();
        }

        public void Myfun2()
        {
            throw new NotImplementedException();
        }
    }
}
