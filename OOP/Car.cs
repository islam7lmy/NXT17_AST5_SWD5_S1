using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        /// attributes or fields
        /// Id , Model , Speed

        //public int Id;

        //clr will generate backingfield
        public int Id { get; set; }


        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value.Length <= 3 ? value : value.Substring(0, 3); }
        }

        public int Speed { get; set; }

        //clr will generate default parameterless constructor ,if no user defined constructor exists
        //public Car() { } Default constructor=> do nothing

        ///Constructor chaning:
        ///Calling Constructor from anthor constructor
        public Car(int _id , string _model, int _speed)
        {
            Id = _id ;
            Model = _model;
            Speed = _speed ;
            Console.WriteLine("ctor 04");
        }
        public Car(int _id, string _model) : this( _id , _model, 320)
        {
            //Id = _id;
            //Model = _model;
            //Speed = 320;
            Console.WriteLine("ctor 03");
        }

        public Car(int _id) : this(_id,"BMW")
        {
            //Id = _id;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("ctor 02");
        }

        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 320;
            Console.WriteLine("ctor 01");
        }
    }
}
