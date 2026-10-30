using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    class Address
    {
        public string City { get; set; }
    }

    internal class Employee : ICloneable,IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        //public string Address { get; set; }
        public Address empAddress { get; set; } //=> reference

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {empAddress.City} :: {Salary} ";
        }

        public Employee()
        {

        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            //empAddress = emp.empAddress; //shallow copy
            empAddress = new Address() { City = emp.empAddress.City };
            Salary = emp.Salary;
        }

        public static Employee DeepCopy(Employee emp)
        {
            //Employee empCopy = new Employee();
            //empCopy.Id = emp.Id;
            //empCopy.Name = emp.Name;
            //empCopy.Address = emp.Address;
            //empCopy.Salary = emp.Salary;

            //return empCopy;

            //Employee empCopy02 = new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Address = emp.Address,
            //    Salary = emp.Salary,
            //};

            //return empCopy02;

            //return new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Address = emp.Address,
            //    Salary = emp.Salary,
            //};

            return new Employee(emp);
        }

        public object Clone()
        {
            ///this keyword => refere to object that call method
            return new Employee(this);
        }

        //public Employee Clone()
        //{
        //    ///this keyword => refere to object that call method
        //    return new Employee(this);
        //}

        public int CompareTo(object? obj)
        {
            Employee other = (Employee)obj;

            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else return 0;

            return this.Salary.CompareTo(other.Salary);
        }
    }
}
