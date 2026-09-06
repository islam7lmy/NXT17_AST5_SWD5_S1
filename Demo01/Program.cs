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
            //Point P1;
            ///// allocate 4 bytes in stack memory for reference variable P1, referring to null
            ///// zero bytes allocated in heap memory for Point object

            ////Console.WriteLine(P1.X); // error: use of unassigned local variable 'P1'

            //P1 = new Point();
            ///// new 
            ///// 1. allocate Required bytes in heap memory for Point object, 8 byte [int x => 4byte, int y => 4byte]
            ///// 2. initialize the Point object with default values (x=0, y=0)
            ///// 3. call user-defined constructor (if any) to further initialize the Point object
            ///// 4. assign the address of the Point object in heap memory to the reference variable P1 in stack memory

            //Console.WriteLine($"P1:{P1.GetHashCode()}");

            //Point P2 = new Point();

            //Console.WriteLine($"P2:{P2.GetHashCode()}");

            //Console.WriteLine("After Assign");
            //P2 = P1; /// assign address of P1 to P2, now both P1 and P2 refer to the same Point object in heap memory
            //Console.WriteLine($"P1:{P1.GetHashCode()}");
            //Console.WriteLine($"P2:{P2.GetHashCode()}");

            //P1.X = 10;
            ///// change value of X in Point object referred by P1 and P2

            //Console.WriteLine($"P1.X : {P1.X}");
            //Console.WriteLine($"P2.X : {P2.X}");
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

            #region Fractions and Discards
            //int X = 1_000_000_000; //_ discard to imporve readabilty

            //double d1 = 3.5;
            //float f1 = 3.5f;
            //decimal m1 = 3.5m;
            #endregion

            #region value type casting
            ///1. implicit casting (safe casting)
            //int x = 5;
            //long y = x; //implicit casting from int to long

            //x = y; //implicit casting from long to int (may cause data loss if y is too large)
            //compile time error : cannot implicitly convert long to int

            ///2. explicit casting (unsafe casting)
            //y = 1_000_000_000_000; //assign y large value

            //x = (int)y;// Explicit casting from long to int (may cause data loss if Y is too large)

            //Console.WriteLine($"Y = {y}");
            //Console.WriteLine($"X = {x}");

            //checked
            //{
            //    int z = (int)y;
            //    unchecked
            //    {
            //        Console.WriteLine($"Z = {z}");
            //    }
            //}

            /// 3. parsing (string to value type) => unsafe casting
            //Console.WriteLine("please enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter your age:");
            //int age = int.Parse(Console.ReadLine()); //"33" => "thirty three"
            //Console.WriteLine($"Hello {name}, your age is {age}");
            //Console.WriteLine("hello");

            /// 4. tryparse (string to value) => safe casting
            //Console.WriteLine("please enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter your age:");
            ////int age = int.Parse(Console.ReadLine()); //"33" => "thirty three"
            //if (int.TryParse(Console.ReadLine(), out int age))
            //    Console.WriteLine($"Hello {name}, your age is {age}");
            //else
            //    Console.WriteLine("Invalid age input. Please enter a valid integer.");
            //Console.WriteLine("hello");

            /// 5. convert(any datatype to any datatype) => unsafe casting
            //Console.WriteLine("please enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine()); //"33" => "thirty three"
            //Console.WriteLine($"Hello {name}, your age is {age}");
            #endregion

            #region Operators

            #region Unary Operator
            //int x = 10;
            ////x++; // x = x + 1
            ////++x; // x = x + 1
            ////x--; // x = x - 1
            ////--x; // x = x - 1

            /////1. prefix increment operator (++x) : increments the value of X by 1 and returns the incremented value
            //Console.WriteLine(++x); // increment x to 11 then print 11
            /////2. postfix increment operator (x++) : returns the current value of X and then increments the value of X by 1
            //Console.WriteLine(x++); // print 11 then increment x to 12

            //Console.WriteLine(x); // print 12

            ///// 3. prefix decrement operator (--X) : decrements the value of X by 1 and returns the decremented value
            //Console.WriteLine(--x); // decrement x to 11 then print 11
            ///// 4. postfix decrement operator (X--) : returns the current value of X and then decrements the value of X by 1
            //Console.WriteLine(x--); // print 11 then decrement x to 10

            //Console.WriteLine(x); // print 10
            #endregion

            #region Binary operater
            //int Sum, Mul, Sub, Div, Mod, num01 = 10, num02 = 3;
            //Sum = num01 + num02; //addition
            //Mul = num01 * num02; //Multiplication
            //Sub = num01 - num02; //subtraction
            //Div = num01 / num02; //divison 
            //Mod = num01 % num02; //modulus

            //int x = 10 / 3; // integer division, result is 3
            //Console.WriteLine(x); // output : 3

            //double y = 10 / 3;
            //Console.WriteLine(y); //output : 3

            //x =(int) 10.0 / 3; // integer division, result is 3
            //Console.WriteLine(x); // output : 3

            //y = 10 / 3.0;
            //Console.WriteLine(y); //output : 3.3333333333333335

            //int Div2 =(int) ((double) num01 / num02);
            //double Div3 =(double) num01 / num02;

            #endregion

            #region Assignment operator
            //int x;
            //x = 5; // assignment operator
            //x += 10; // addition assignment operator, equivalent to X = X + 10
            //x -= 3; // subtraction assignment operator, equivalent to X = X - 3
            //x *= 2; // multiplication assignment operator, equivalent to X = X * 2
            //x /= 4; // division assignment operator, equivalent to X = X / 4
            //x %= 3; // modulus assignment operator, equivalent to X = X % 3

            //x %= 2;
            #endregion

            #region Realtional Operator [Comparision]
            //int X = 10, Y = 20;
            //Console.WriteLine(X == Y); //equality operator // false
            //Console.WriteLine(X != Y); //inequilty operator
            //Console.WriteLine(X > Y); //greater than operator
            //Console.WriteLine(X < Y); //less than operator
            //Console.WriteLine(X >= Y); //greater than or equal operator
            //Console.WriteLine(X <= Y); //less than or equal operator
            #endregion

            #region Logical Operator
            //Console.WriteLine(!false); // logical NOT operator, negates the boolean value, Output: True
            ///// logical AND operator (&&) and lofgical OR operator (||) are short-circuit operators, meaning they only evaluate the second operand if necessary.
            //Console.WriteLine(false && true); // logical AND operator, returns true if both operands are true, Output: False
            //Console.WriteLine(false || true); // logical OR operator, returns true if at least one operand is true, Output: True

            //Console.WriteLine((4 > 5) && (7 < 9 || 5 == 5));
            #endregion

            #region bitwise operator
            //Console.WriteLine(false & true); // bitwise AND operator, returns true if both operands are true, Output: False
            //Console.WriteLine(false | true); // bitwise OR operator, returns true if at least one operand is true, Output: True
            //Console.WriteLine(true ^ false); // bitwise XOR operator, returns true if operands are different, Output: True  
            #endregion

            #region ternary operator
            //int X = 4, Y = 7, Z = 10;
            //if (X > Y)
            //    Console.WriteLine("X is greater than Y");
            //else
            //    Console.WriteLine("Y is greater than x");

            //Console.WriteLine(X > Y ? "X is greater than Y" : "Y is greater than x");


            //if (X > Y)
            //{
            //    if(X > Z)
            //        Console.WriteLine("X is the greatest");
            //    else
            //        Console.WriteLine("Z is the greatest");
            //}
            //else if (Y > Z)
            //    Console.WriteLine("Y is the greatest");
            //else
            //    Console.WriteLine("Z is the greatest");

            /////// not recommended to use nested ternary operator for better readability
            //Console.WriteLine(X > Y ? (X > Z ? "X is the greatest" : "Z is the greatest") : (Y > Z ? "Y is the greatest" : "Z is the greatest"));

            #endregion

            #region Operator priorty [Quiz]
            ///1. unary operator
            ///2. round brackets ((()))
            ///3. multiplicative operator (*, /, %)
            ///4. additive operator (+ , -)

            //int a = 20, b = 10, c = 15, d = 5;
            //int result = (a + b) * c / d;
            //int result2 = ((--a + b) * c) / d;
            //int result3 = --a + b * c / d; 
            //int result4 = ++a + a++ - --a - a--;
            #endregion
            #endregion
        }
    }
}
