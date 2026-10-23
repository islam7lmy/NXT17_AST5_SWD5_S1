using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_Overriding
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void ShowRole()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Employee : Id = {Id} , Name = {Name} , Age = {Age}");
        }
    }
    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void ShowRole()
        {
            Console.WriteLine("I am FullTimeEmployee");
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"FullTimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }

        public override void ShowRole()
        {
            Console.WriteLine("I am PartTimeEmployee");
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"PartTimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , HourRate = {HourRate} , CountOfHours = {CountOfHours}");
        }
    }

    class FreeLanceEmployee : Employee
    {
        
        public decimal ProjectPrice { get; set; }


        public new void ShowRole()
        {
            Console.WriteLine("I am FreeLanceEmployee");
        }

        public new void PrintDetails()
        {
            Console.WriteLine($"FreeLanceEmployee : Id = {Id} , Name = {Name} , Age = {Age} , ProjectPrice = {ProjectPrice}");
        }
    }
}
