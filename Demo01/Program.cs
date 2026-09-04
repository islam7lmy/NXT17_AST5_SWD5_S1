namespace Demo01
{
    /// <summary>
    /// The Program class is the entry point of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ctrl + K + S 
            #region Comment
            // line comment
            /*
             * block comment
             * block comment
             */
            #endregion

            #region Value Type
            //int X;
            ///// allocate 4 unintialized bytes in stack memory
            ///// int is a value type, so it is stored in stack memory
            ///// int : C# keyword for 32-bit signed integer

            //// Console.WriteLine(X); // error: use of unassigned local variable 'X'

            //X = 10; // assign value to X

            //Int32 Y; // Int32 is a .NET type for 32-bit signed integer
            ///// allocate 4 unintialized bytes in stack memory

            //Y = X; // assign value of X to Y 

            //X = 20; // change value of X

            //Console.WriteLine($"X = {X}, Y = {Y}");
            #endregion

            #region Reference Type
            Point P1;
            /// allocate 4 bytes in stack memory for reference variable P1, referring to null
            /// zero bytes allocated in heap memory for Point object

            //Console.WriteLine(P1.X); // error: use of unassigned local variable 'P1'

            P1 = new Point();
            /// new 
            /// 1. allocate Required bytes in heap memory for Point object, 8 byte [int x => 4byte, int y => 4byte]
            /// 2. initialize the Point object with default values (x=0, y=0)
            /// 3. call user-defined constructor (if any) to further initialize the Point object
            /// 4. assign the address of the Point object in heap memory to the reference variable P1 in stack memory

            Console.WriteLine($"P1:{P1.GetHashCode()}");

            Point P2 = new Point();

            Console.WriteLine($"P2:{P2.GetHashCode()}");

            Console.WriteLine("After Assign");
            P2 = P1; /// assign address of P1 to P2, now both P1 and P2 refer to the same Point object in heap memory
            Console.WriteLine($"P1:{P1.GetHashCode()}");
            Console.WriteLine($"P2:{P2.GetHashCode()}");

            P1.X = 10;
            /// change value of X in Point object referred by P1 and P2

            Console.WriteLine($"P1.X : {P1.X}");
            Console.WriteLine($"P2.X : {P2.X}");
            #endregion

            #region object
            //Point o1 = new Point();
            //int x = 10;
            //object o2 = new object();

            //o1.ToString(); // call ToString() method of Point class
            //o1.Equals(o2); // call Equals() method of Point class, which is inherited from object class
            //o1.GetHashCode(); // call GetHashCode() method of Point class, which is inherited from object class
            //o1.GetType(); // call GetType() method of Point class, which is inherited from object class
            
            //x.ToString(); // call ToString() method of Int32 struct
            //x.Equals(o2); // call Equals() method of Int32 struct, which is inherited from ValueType struct, which is inherited from object class
            //x.GetHashCode(); // call GetHashCode() method of Int32 struct, which is inherited from ValueType struct, which is inherited from object class
            #endregion

        }
    }
}
