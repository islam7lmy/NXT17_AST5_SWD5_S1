using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operator_OverLoading
{
    class Address
    {
        public Address(Address address)
        {
            AddressDetails = address.AddressDetails;
            City = address.City;
            Country = address.Country;
        }
        public Address(string addressDetails, string city, string country)
        {
            AddressDetails = addressDetails ?? throw new ArgumentNullException(nameof(addressDetails));
            City = city ?? throw new ArgumentNullException(nameof(city));
            Country = country ?? throw new ArgumentNullException(nameof(country));
        }

        public string AddressDetails { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    //model
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public Address Address { get; set; }
        public decimal Detuctions { get { return Salary * .2m; } }

        public Employee()
        {

        }
        public Employee(Employee emp)
        {
            Id = emp.Id;
            FirstName = emp.FirstName;
            LastName = emp.LastName;
            BirthDate = emp.BirthDate;
            Salary = emp.Salary;
            //Address = emp.Address; //shallow
            Address = new Address(emp.Address);
        }

    }

    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal NetSalary { get; set; }

        public EmployeeViewModel()
        {

        }

        internal EmployeeViewModel(Employee emp)
        {
            FullName = $"{emp.FirstName} {emp.LastName}";
            Age = DateTime.Now.Year - emp.BirthDate.Year;
            Address = $"{emp.Address.AddressDetails}, {emp.Address.City}, {emp.Address.Country}";
            NetSalary = emp.Salary - emp.Detuctions;
        }

        public static explicit operator EmployeeViewModel(Employee emp)
        {
            return new EmployeeViewModel(emp);
        }
    }

    static class EmployeeExtintions
    {
        public static EmployeeViewModel ToEmployeeViewModel(this Employee emp)
        {
            return new EmployeeViewModel(emp);
        }
    }

    static class Extintions
    {
        public static int Add(this int x, int y)
        { return x + y; }
    }
}
