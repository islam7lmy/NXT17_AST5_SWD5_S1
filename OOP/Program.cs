//using Comman;
//using Comman01;
using Microsoft.VisualBasic;
using OOP.Inheritance;
using OOP.Interfaces;
using OOP.nterfaces;
using OOP.PolyMorphism_Overriding;
using System;
using System.Net;
using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifers
            ///private
            ///private protected => inhertance
            ///protected         => inhertance
            ///internal
            ///internal protected=> inhertance
            ///public
            #region Permission
            ////////write 3 class memeber methos
            //PermissionItems myp = PermissionItems.write;
            ///////function to add permissions => current permission , permission to add => my.addpermission()
            ////AddPermission(ref myp, PermissionItems.read);
            ////AddPermission(ref myp, PermissionItems.delete);
            ////AddPermission(ref myp, PermissionItems.execute);

            //Permission.AddPermission(ref myp, PermissionItems.read, PermissionItems.delete, PermissionItems.execute);

            //Console.WriteLine(myp);

            ///////function to remove permissions
            //Permission.RemovePermission(ref myp, PermissionItems.delete, PermissionItems.execute);

            //Console.WriteLine(myp);

            ///////function to check if permission exists return true else return false

            //Console.WriteLine(Permission.CheckPermission(myp, PermissionItems.read) ? "allowed" : "denaid"); 
            #endregion

            ////rank r = rank.first;

            //TypeA a = new TypeA();
            ////a.x = 10;// invalid because x is private in typeA
            ////a.y = 20;// invalid because y is internal in typeA
            //a.z = 30;// valid because z is public in typeA

            //TypeC c = new TypeC();
            #endregion

            #region Struct
            #region Ex : Point
            //Point p1;
            /// allocate 8 bytes uninitialized in stack memory for p1 
            //Console.WriteLine(p1); // invalid because not intilized

            //p1.X = 10;
            //p1.Y = 10;
            //Console.WriteLine(p1);

            //p1 = new Point();
            /// new key word just for constructor selection and not for memory allocation in stack memory
            ///that will initialize the struct fields with default values

            //p1 = new Point(20);
            //Console.WriteLine(p1.Y); 
            #endregion
            #region EX : Employee
            //Employee emp = new Employee();
            ////emp.Name = "ahmed omar ali ahmed amr";

            //emp = new Employee(10, "ahmed omar ali ahmed amr", 1000, 5);

            //Console.WriteLine(emp.Name);

            ////emp.salary = 10000;
            ////emp.SetSalary(10000);

            //Console.WriteLine(emp.GetSalary());
            //Console.WriteLine(emp.GetAge());
            #endregion
            #region Ex : PhoneBook
            // name => number
            // add contact
            // remove contact
            // get contact by name
            // set contact by name
            //PhoneBook[] book = new PhoneBook[10];
            //book[0].Name = "Test";
            //book[0].Number = "0120000000054";

            //PhoneBook book = new PhoneBook();

            //book.Names = new string[0];
            //book.Numbers = new string[15];

            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");


            //book.AddContact("ahmed", "01000000000000"); //if size of book is full resize book
            //book.AddContact("ali", "01000000000001");
            //book.AddContact("omr", "01000000000002");
            //book.AddContact("amr", "01000000000003");
            //book.AddContact("mohmed", "01000000000004");

            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");

            //for (int i = 0; i < book.Count; i++) /*book.Size*/
            //{
            //    Console.WriteLine(book[i]); //=> ahmed : 01000000000000
            //}

            //Console.WriteLine(book.GetContact(""));
            //book.SetContact("", "");
            //book.RemoveContact("");

            //book["mohmed"] = "010000001235"; //=> setcontact
            //Console.WriteLine(book["mohmed"]); //=> get contact


            #endregion
            #endregion

            #region Class
            #region Ex : Car
            //Car c1; //= new Car(10, "BMW", 320);
            //c1.Id = 10;
            //c1.Model = "BMW";
            //c1.Speed = 320;

            //c1 = new Car(); //=> id = 10 , model = "bmw" , speed = 320 
            //c1 = new Car(20); //=> id = 20 , model = "bmw" , speed = 320 
            //c1 = new Car(20,"BMW"); //=> id = 20 , model = "BMW" , speed = 320 
            //c1 = new Car(10, "BMW", 320); //=> id = 20 , model = "BMW" , speed = 320 

            //c1 = new Car(); 

            //Point p1; //= new Point();
            //p1.X = 10;
            //p1.Y = 20;

            //Console.WriteLine(p1); 

            #endregion
            #region Inhertance
            //Parent p = new Parent(10);
            //Console.WriteLine(p.A);

            //Child c = new Child(10, 20);
            //Console.WriteLine(c.A);
            //Console.WriteLine(c.B);
            #endregion
            #region Class Vs Struct
            ///Car c1 = new Car();
            ///Car c2 = c1; // shallow copy => copy just address
            ///c2.Id = 99;
            ///Console.WriteLine(c1.Id); // 99
            ///Reference Type => stored refernce in stack an d object in heab
            ///instilizition  => Must use new and call constructor
            ///clr will always genrate empty paramterless constructor, if no user-defined constructor exists
            ///clr will no longer generate empty parameterless constructor, if u write user-defined constructor
            ///default Constructor => do notthing
            ///Support Inheritance => [all access modifiers]
            ///used for complex objects and behaviors



            ///Point p1 = new Point();
            ///Point p2 = p1; //deep copy => p2 is a copy of p1  but refer to different memory address
            ///p2.X = 10;
            ///p2.Y = 20;
            ///p2.X = 99;
            ///Console.WriteLine(p1.X); // 0
            ///Value Type => stored in stack
            ///instilizition  => not must call constructor
            ///clr will generate Parameterless constructor
            ///default constructor => initialize the attributes of struct with default values
            ///Cannot inherit from another struct =>  [private, internal, public]
            ///often used for small and simple ata => recomanded 16 bytes or less


            //PhoneBook book = new PhoneBook();
            //book.AddContact("ahmed", "010123456789");
            //book.AddContact("ali", "010123456788");
            //book.AddContact("omr", "010123456787");

            //PhoneBook book1 = book;
            //book1.Names = new string[10];
            //book1.Numbers = new string[10];
            //book1["ahmed"] = "000000000000000";

            //Console.WriteLine(book["ahmed"]);   //000000000000000
            //Console.WriteLine(book1["ahmed"]);  //000000000000000
            #endregion
            #endregion

            #region PolyMorphism
            #region OverLoading
            //int num1 = 10, num2 = 20;
            //Sum(num1, num2);

            //double num3 = 10.5, num4 = 15.25;


            //double num5 = 10.65;
            //long num6 = 123456789;
            #endregion
            #region Overriding
            //PolyMorphism_Overriding.TypeA typeA = new PolyMorphism_Overriding.TypeA(10);
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeB(10, 20);
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion
            #endregion

            #region Binding
            //PolyMorphism_Overriding.Employee emp;
            ///// allocate 4 byte for reference from type employee in stack refer to null

            //emp = new PolyMorphism_Overriding.Employee();
            ///// allocate object in heap

            #region What is binding
            ///// reference from base type => object from derived type
            //emp = new FullTimeEmployee();
            //emp.Id = 10;
            //emp.Name = "ahmed";
            //emp.Age = 30;
            ////emp.Salary = 20000; //not valid

            //emp.ShowRole(); //hidding => static => will run related to reference
            //emp.PrintDetails(); //overriding => dynamic => will run related to object


            //PolyMorphism_Overriding.Employee emp = new PolyMorphism_Overriding.Employee();
            ////emp.ShowRole();
            //ProceesEmployee(emp);
            //PolyMorphism_Overriding.FullTimeEmployee emp01 = new PolyMorphism_Overriding.FullTimeEmployee();
            ////emp01.ShowRole();
            //ProceesEmployee(emp01);
            //PolyMorphism_Overriding.PartTimeEmployee emp02 = new PolyMorphism_Overriding.PartTimeEmployee();
            ////emp02.ShowRole();
            //ProceesEmployee(emp02);
            //PolyMorphism_Overriding.FreeLanceEmployee emp03 = new PolyMorphism_Overriding.FreeLanceEmployee();
            ////emp03.ShowRole();
            //ProceesEmployee(emp03);
            #endregion
            #region Not Binding
            //FullTimeEmployee emp = new FullTimeEmployee();

            //PolyMorphism_Overriding.Employee emp01 = new FullTimeEmployee();


            //FullTimeEmployee emp02 =(FullTimeEmployee) new PolyMorphism_Overriding.Employee();

            //int x = 10;
            //object obj = x;
            //obj = "test";
            //x =(int) obj;

            ////animal = dog
            ////animal = cat
            ////dog =(dog) animal
            #endregion
            #region More Practise on Binding
            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 11;
            ////typeA.B = 10;
            ////typeA.C = 20;

            //typeA.MyFun01(); //typeA
            //typeA.MyFun02(); //typeC

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 11;
            //typeB.B = 10;
            ////typeA.C = 20;

            //typeB.MyFun01(); //typeB
            //typeB.MyFun02(); //typeC

            //TypeA typeA1 = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB1 = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC1 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD1 = new TypeD(1, 2, 3, 4);
            //TypeD typeD2 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD3 = new TypeF(1, 2, 3, 4, 5);

            //typeA1.MyFun02(); //TypeC
            //typeB1.MyFun02(); //TypeC
            //typeC1.MyFun02(); //TypeC
            //typeD1.MyFun02(); //TypeD
            //typeD2.MyFun02(); //TypeE
            //typeD3.MyFun02(); //TypeD


            #endregion
            #endregion

            #region Interfaces
            #region Ex01
            //MyType myType = new MyType();
            //MyTypeV2 myType = new MyTypeV2();

            ///not valid to create object from interface because it's not fully implmented
            ///IMytype mytype = new IMytype();
            //IMytype myType = new MyType();  //MyType();
            //myType.Salary = 100;
            //myType.Myfun();
            //myType.Myfun2();
            ////myType.Print(); //not valid
            //myType.IPrint(); //=> default implment method


            //MyType myType01 = new MyType();
            //myType01.IPrint(); //not valid  => to call default implment method from implmented class 
            #endregion
            #region Ex02
            /// series by two => 0  2   4   6   8
            /// series by three => 0   3   6   9   12
            /// Series as datatype => current , getnext , reset 
            /// class memeber method to print one line of series of specifed number user can decide
            /// extend not refactor

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrintSeriesLine(20, seriesByTwo);


            //SeriesBySeven seriesBySeven = new SeriesBySeven();
            //PrintSeriesLine(50, seriesBySeven);

            #endregion
            #region Implment Interface Implicitly Vs Implment Interface Explicitly
            //Interfaces.Car car = new Interfaces.Car();
            //car.Speed = 20;
            //car.Backward();
            //car.Forward();
            //car.Left();
            //car.Right();


            //AirPlan airPlan = new AirPlan();
            //airPlan.Speed = 100;
            //not valid => because it's explicit implmintation
            //airPlan.Forward();
            //airPlan.Left();
            //airPlan.Right();

            //IMoveable moveablePlan = airPlan;
            //moveablePlan.Speed = 100;
            //moveablePlan.Backward();
            //moveablePlan.Forward();
            //moveablePlan.Left();
            //moveablePlan.Right();


            //IFlyable flyablePlan = airPlan;
            //flyablePlan.Speed = 500; // => implicit implmentation
            ////flyablePlan.Backward(); //not valid
            //flyablePlan.Forward();
            //flyablePlan.Left();
            //flyablePlan.Right();

            #endregion
            #region Shallow Copy vs Deep Copy
            //int x = 10;
            //int y = 20;
            //y = x;
            //y = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };

            //Console.WriteLine($"arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 = {arr02.GetHashCode()}");

            #region Shallow Copy [default for reference type]
            //arr02 = arr01;
            //Console.WriteLine("after Shallow copy");

            //Console.WriteLine($"arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 = {arr02.GetHashCode()}");

            //arr02[0] = 99;
            //Console.WriteLine(arr01[0]);
            #endregion
            #region Deep Copy
            ////arr02 = new int[] { 1, 2, 3 };
            ////arr02 = (int[]) new object();
            //arr02 = (int[]) arr01.Clone();
            //Console.WriteLine("after Deep copy");

            //Console.WriteLine($"arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 = {arr02.GetHashCode()}");

            ////arr02[0] = 99;
            ////Console.WriteLine(arr01[0]);

            //foreach (int item in arr02)
            //{
            //    Console.Write($"{item}\t");
            //}
            //Console.WriteLine();

            ////reference compare address (gethashcode)
            //if(arr01 == arr02)
            //    Console.WriteLine("equal");
            //else
            //    Console.WriteLine("Not equal");
            #endregion

            #endregion
            #region Built-In Interface ICloneable
            //Interfaces.Employee emp01 = new Interfaces.Employee()
            //{
            //    Id = 1,
            //    Name = "Foo",
            //    empAddress = new Address() { City = "cairo" },
            //    Salary = 1000
            //};
            //Console.WriteLine(emp01);

            //Interfaces.Employee emp02 = new Interfaces.Employee()
            //{
            //    Id = 2,
            //    Name = "two",
            //    empAddress = new Address() { City = "cairo" },
            //    Salary = 2000
            //};
            //Console.WriteLine(emp02);

            //Console.WriteLine($"Emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02 : {emp02.GetHashCode()}");

            /////make me can to Deep Copy Employee
            ////emp02 = Interfaces.Employee.DeepCopy(emp01);
            //emp02 = (Interfaces.Employee) emp01.Clone();

            //Console.WriteLine("after Deep copy");
            //Console.WriteLine($"Emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02 : {emp02.GetHashCode()}");

            //emp02.empAddress.City = "test";

            //Console.WriteLine(emp01);
            //Console.WriteLine(emp02);
            #endregion
            #region Built-In Interface IComparable
            //int[] arr = { 9, 8, 11, 7, 2, 3, 4, 5, 1 };
            ////Array.Sort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {
            //        //if (arr[j] > arr[j + 1])
            //        //+ve : arr[j] > arr[j + 1]
            //        //-ve : arr[j] < arr[j + 1]
            //        //0 : arr[j] == arr[j + 1]
            //        if (arr[j].CompareTo(arr[j + 1]) > 0)
            //            Swap(ref arr[j], ref arr[j + 1]);
            //    }
            //}

            //foreach (int i in arr)
            //{
            //    Console.Write($"{i} \t");
            //}

            //string[] strings = { "omr", "ahmed", "ali" };
            ////Array.Sort(strings);
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    for (int j = 0; j < strings.Length - i - 1; j++)
            //    {
            //        if (strings[j].CompareTo(strings[j + 1]) > 0)
            //            Swap(ref strings[j], ref strings[j + 1]);
            //    }
            //}
            //foreach (string i in strings)
            //{
            //    Console.Write($"{i} \t");
            //}

            //Interfaces.Employee[] employees =
            //{
            //    new Interfaces.Employee() { Id = 10 , Name = "Ahmed" , empAddress =new Address(){ City = "Cairo" }, Salary = 10_000},
            //    new Interfaces.Employee() { Id = 20 , Name = "Ali" , empAddress =new Address(){ City = "Alex"}, Salary = 4_000},
            //    new Interfaces.Employee() { Id = 30 , Name = "Omar" , empAddress =new Address(){ City = "Asyut"}, Salary = 8_000},
            //    new Interfaces.Employee() { Id = 40 , Name = "Amr" , empAddress =new Address(){ City = "Fayoum"}, Salary = 5_000},
            //};

            //Array.Sort(employees);
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    for (int j = 0; j < employees.Length - i - 1; j++)
            //    {
            //        if (employees[j].CompareTo(employees[j + 1]) > 0)
            //            Swap(ref employees[j], ref employees[j + 1]);
            //    }
            //}

            //foreach (Interfaces.Employee i in employees)
            //{
            //    Console.WriteLine($"{i}");
            //}
            #endregion
            #endregion
        }

        #region PolyMorphism 1. function overloading
        ///1. datatype of parameters
        ///2. count number of parameters
        ///3. reorder parameters if not same datatype

        public static int Sum(int x, int y)
        {
            return x + y;
        }
        //public static double Sum(int x, int y) //not overloading
        //{
        //    return x + y;
        //}
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sum(double x, int y)
        {
            return x + y;
        }
        public static double Sum(int y, double x)
        {
            return x + y;
        }

        //public static decimal calcbill(params orderitems[] items)
        //{
        //    return 123m;
        //}

        //public static decimal calcbill(decimal taxrate, params orderitems[] items)
        //{
        //    decimal tax = 123m * taxrate / 100;
        //    return 123m + tax;
        //}
        #endregion

        #region Binding
        /// create reference form parent type => refere to object from child type
        public static void ProceesEmployee(PolyMorphism_Overriding.Employee emp)
        {
            if (emp is not null)
            {
                emp.ShowRole();
                emp.PrintDetails();
            }
        }

        //public static void ProceesEmployee(FullTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetails();
        //    }
        //}
        //public static void ProceesEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetails();
        //    }
        //}
        //public static void ProceesEmployee(FreeLanceEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetails();
        //    }
        //}
        #endregion

        #region Interfaces
        public static void PrintSeriesLine(int countofelements, ISeries series)
        {
            for (int i = 0; i < countofelements; i++)
            {
                Console.Write($"{series.Current} \t");
                series.GetNext();
            }
            Console.WriteLine();
            series.Reset();
        }

        //public static void PrintSeriesLine(int countofelements, SeriesByTwo series)
        //{
        //    for (int i = 0; i < countofelements; i++)
        //    {
        //        Console.Write($"{series.Current} \t");
        //        series.GetNext();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //public static void PrintSeriesLine(int countofelements, SeriesByThree series)
        //{
        //    for (int i = 0; i < countofelements; i++)
        //    {
        //        Console.Write($"{series.Current} \t");
        //        series.GetNext();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        public static void Swap(ref IComparable a, ref IComparable b)
        {
            IComparable temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref Interfaces.Employee a, ref Interfaces.Employee b)
        {
            Interfaces.Employee temp = a;
            a = b;
            b = temp;
        }

        public static void Sorting(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                        Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        #endregion
    }
}
