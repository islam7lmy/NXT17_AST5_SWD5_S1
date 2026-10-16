using System;
using System.Collections.Generic;
using System.Linq;
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

        public Car(int _id , string _name , int _speed)
        {
            
        }

    }
}
