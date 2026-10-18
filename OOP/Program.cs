using Comman;
using Comman01;
using OOP.Inheritance;
using System;
using System.Security;

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
    }
}
