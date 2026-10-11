using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        //public int Id;
        //string name; //max length 20
        decimal Salary; //min 2000
        int Age; //min 18, max 60

        public Employee() : this(/*0,*/ string.Empty, 0, 0)
        {
            //Id = default;
            //Name = string.Empty;
            //SetSalary(0);
            //SetAge(0);

        }

        public Employee(/*int _id,*/ string _name, decimal _salary, int _age)
        {
            //Id = _id;
            Name = _name;
            //Salary = _salary < 2000 ? 2000 : _salary;
            //Salary = _salary;
            SetSalary(_salary);
            SetAge(_age);
        }

        //encapsulation : seprate the data defintion (attributes) from it's usage (GetterSetter or Property)
        #region Id [automatic property] => BackingField (hidden private field) + property (Methods)
        //clr will generate backingfield (hidden private field)
        public int Id { get; private set; }
        #endregion

        #region Name [Full Property] => Field + property (Methods)
        //propfull + tab + tab
        private string name;

        public string Name
        {
            get { return name ?? "N/A"; }
            private set { name = value.Length <= 20 ? value : value.Substring(0, 20); }
        }
        #endregion

        #region Salary
        public decimal GetSalary()
        {
            return Salary;
        }

        public void SetSalary(decimal salary)
        {
            Salary = salary < 2000 ? 2000 : salary;
        }
        #endregion

        #region Age
        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            if (age >= 18 && age <= 60)
                Age = age;
            else if (age < 18)
                Age = 18;
            else if (age > 60)
                Age = 60;
        }
        #endregion

        #region Deductions [automatic property has only get]
        public decimal Deductions
        {
            get
            {
                return Salary * .2m;
            }
        }
        #endregion
    }
}
