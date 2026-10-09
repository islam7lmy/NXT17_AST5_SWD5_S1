using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Point
    {
        /// What You Can Write Inside The Class Or Struct?
        /// 1. variables => fields (Attributes)
        /// 2. functions => Methods
        /// 3. Constructor => special method
        /// 4. Properties
        /// 5. Events
        /// 6. Indexers

        public int X;
        public int Y;

        ///clr will create a default constructor for the struct 
        ///that will initialize the fields with default values
        /// You Can't Create User-Defined Parameterless Constructor 
        /// Inside Struct (Except C# 10.0)
        //public Point()
        //{
        //    X = default;
        //    Y = default;
        //}

        public Point(int X)
        {
            this.X = X;
        }
    }
}
