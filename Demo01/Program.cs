using System;
using System.Collections;
using System.Text;

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

            #region string vs stringbuilder
            //string x = "hello"; //string x = new string("hello");
            //Console.WriteLine(x.GetHashCode());
            //x = "world"; //x = new string("world");
            //Console.WriteLine(x.GetHashCode());
            //x += "!!!";
            //Console.WriteLine(x.GetHashCode());
            //////////////////////////////////////////////////////////////
            //StringBuilder x = new StringBuilder("hello");
            //Console.WriteLine(x.GetHashCode());
            //x.Append(" world");
            //Console.WriteLine(x.GetHashCode());
            //x.Clear();
            //x.AppendLine("world C#");
            //x.Remove(1, 11);
            //x.Replace("C#","DEPI");
            //x.Insert(0, "welcome");
            //Console.WriteLine(x);
            #endregion

            #region string Formatting
            //Equation : 4 + 2 = 6
            //int x = 4, y = 2;

            //string result = "Equation : " + x + " + " + y + " = " + (x + y);

            //string result1 = "Equation : ";
            //result1 += x;
            //result1 += " + ";
            //result1 += y;
            //result1 += " = ";
            //result1 += (x + y);

            //StringBuilder result2 = new StringBuilder("Equation : ");
            ////block of code
            //result2.Append(x);
            ////block of code
            //result2.Append(" + ");
            //result2.Append(y);
            //result2.Append(" = ");
            //result2.Append(x + y);

            //string result3 = string.Format("Equation : {0} + {1} = {2}", x, y, (x + y));

            //string result4 = $"Equation : {x} + {y} = {x + y}";

            #endregion

            #region Conditional Statment
            //if(condition) //true or false
            //{
            //    // excute statment if condition1 is true
            //}
            //else if(condition2) 
            //{
            //    // excute statment if condition2 is true
            //}
            //else
            //{
            //    // excute statment if all conditions false
            //}

            //if(condition)
            //{

            //}

            //if(condition2)
            //{

            //}
            //else
            //{

            //}

            //varible = Value;
            ////jumptable
            //switch(varible)
            //{
            //    case value1:
            //        //excute code
            //        break;
            //    case value2:
            //        //excute code
            //        break;
            //    default:
            //        break;
            //}

            #region EX01:
            //write a protictive program to take from user number in first quarter of year
            //then print equlavint month of it

            #region IF
            //Console.WriteLine("insert number of month in first qurter of year :");
            ////int month = int.Parse(Console.ReadLine());
            ////if (int.TryParse(Console.ReadLine(), out int month))
            ////{
            ////    if (month == 1)
            ////        Console.WriteLine("jan");
            ////    else if (month == 2)
            ////        Console.WriteLine("fab");
            ////    else if (month == 3)
            ////        Console.WriteLine("mar");
            ////    else
            ////        Console.WriteLine("wrong month number");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("wrong format for month number");
            ////}
            ////Console.WriteLine("Hello");


            //if (!int.TryParse(Console.ReadLine(), out int month))
            //    Console.WriteLine("wrong format for month number");

            //if (month == 1)
            //    Console.WriteLine("jan");
            //else if (month == 2)
            //    Console.WriteLine("fab");
            //else if (month == 3)
            //    Console.WriteLine("mar");
            //else
            //    Console.WriteLine("wrong month number");
            #endregion
            #region switch
            //Console.WriteLine("insert number of month in first qurter of year :");
            //if (!int.TryParse(Console.ReadLine(), out int month))
            //    Console.WriteLine("wrong format for month number");
            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine("jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("fab");
            //        break;
            //    case 3:
            //        Console.WriteLine("mar");
            //        break;
            //    default:
            //        Console.WriteLine("wrong month number");
            //        break;
            //}
            #endregion
            #endregion
            #region Ex:02
            //int salary = 3000;
            //switch(salary)
            //{
            //    case 3000:
            //        Console.WriteLine("option03");
            //        //Console.WriteLine("option02");
            //        //Console.WriteLine("option01");
            //        //break;
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option02");
            //        //Console.WriteLine("option01");
            //        break;
            //    case 1000:
            //        Console.WriteLine("option01");
            //        // break;
            //        goto case 3000;
            //}
            #endregion
            #region EX:03
            //write a protictive program to calculater that do (+ - / * %) take number then operator then number 
            //and return result
            //numbers is int and result is double and operator is char
            //double result = 0;

            //Console.WriteLine("enter first number");
            //if(!int.TryParse(Console.ReadLine(),out int num01))
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer");
            //    return;
            //}

            //Console.WriteLine("enter operator (+  -  /   %   *)");
            //if (!char.TryParse(Console.ReadLine(),out char op))
            //{
            //    Console.WriteLine("Invalid Input, please enter valid char");
            //    return;
            //}

            //if(!(op == '+' || op == '-' || op == '/' || op == '%' || op == '*'))
            //{
            //    Console.WriteLine("Invalid Input, please enter valid Operator");
            //    return;
            //}

            ////if(!(char.TryParse(Console.ReadLine(), out char op)
            ////    &&
            ////    (op == '+' || op == '-' || op == '/' || op == '%' || op == '*')))
            ////{

            ////}

            //Console.WriteLine("enter last number");
            //if (!int.TryParse(Console.ReadLine(), out int num02))
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer");
            //    return;
            //}

            //if((op == '/' || op == '%') && num02 == 0)
            //{
            //    Console.WriteLine("invalid Input, You can not devid by zero");
            //    return;
            //}

            ////if(!int.TryParse(Console.ReadLine(), out int num02)
            ////    ||
            ////    ((op == '/' || op == '%') && num02 == 0))
            ////{
            ////    Console.WriteLine("Invalid Input, please enter a valid integer");
            ////    return;
            ////}

            //switch(op)
            //{
            //    case '+': result = num01 + num02; break;
            //    case '-': result = num01 - num02; break;
            //    case '*': result = num01 * num02; break;
            //    case '/': result = (double)num01 / num02; break;
            //    case '%': result = num01 % num02; break;
            //    //default: result = 0; break; 
            //}
            //Console.WriteLine(result);

            #endregion
            #endregion

            #region Loops statment
            // 10 steps to print 1 to 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            #region For
            // start => i = 1
            // condition => i<= 10 => true
            // excute => Console.WriteLine(i);
            // increment => i++
            // condition => i<= 10 => true
            // excute => Console.WriteLine(i);
            // increment => i++
            // condition => i<= 10 => false


            //for (int i = 1; i <= 10; i++) //++i
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1; //start
            //for (; ; i++)
            //{
            //    if (!(i <= 10))
            //    {
            //        //stop loop
            //        break;
            //    }

            //    if(i % 2 == 0)
            //    { 
            //        //i++;
            //        //skip current round
            //        continue;

            //    }

            //    //excute
            //    Console.WriteLine(i);

            //    // increment
            //    //i++;
            //}
            #endregion

            #region while


            //Console.WriteLine("enter first number");
            //while (!int.TryParse(Console.ReadLine(), out int num01))
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer");
            //    //return;
            //}
            #endregion

            #region do while
            //string input;
            //do
            //{
            //    Console.WriteLine("insert 0 if you want to stop");
            //    input = Console.ReadLine();
            //    Console.WriteLine($"you entered : {input}");
            //} while (input != "0");

            //do
            //{
            //    Console.WriteLine("enter first number");
            //} while (!int.TryParse(Console.ReadLine(), out int num01));
            #endregion

            #region Foreach
            //List<string> names = new List<string>()
            //{ 
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};

            ////allow  modification
            //for (int i = 0; i < names.Count ; i++)
            //{
            //    names[i] = "test";
            //    Console.WriteLine(names[i]);
            //}

            ////not allow modification
            //foreach(string item in names)
            //{
            //    //item = "test"; //invalid
            //    Console.WriteLine(item);
            //}
            #endregion

            //[quiz] write calculater program using while loop and switch statment and make it protictive
            //int num01, num02;
            //char op;
            //double result = 0;

            //Console.WriteLine("enter first number");
            //while (!int.TryParse(Console.ReadLine(), out num01))
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer");
            //}

            //Console.WriteLine("enter operator (+  -  /   %   *)");
            //while (!(char.TryParse(Console.ReadLine(), out op)
            //    &&
            //    (op == '+' || op == '-' || op == '/' || op == '%' || op == '*')))
            //{
            //    Console.WriteLine("Invalid Input, please enter valid Operator");
            //}

            //while (!int.TryParse(Console.ReadLine(), out num02)
            //    ||
            //    ((op == '/' || op == '%') && num02 == 0))
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer");
            //    return;
            //}

            //switch (op)
            //{
            //    case '+': result = num01 + num02; break;
            //    case '-': result = num01 - num02; break;
            //    case '*': result = num01 * num02; break;
            //    case '/': result = (double)num01 / num02; break;
            //    case '%': result = num01 % num02; break;
            //    //default: result = 0; break; 
            //}
            //Console.WriteLine(result);
            #endregion

            #region block scpoe
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 10;
            ////i = 3;
            //Console.WriteLine(i); //invalid [out of scope]

            //{
            //    //int i = 5;
            //    { int i = 3; } //block
            //    { int i = 10; } //block
            //}

            //while(!int.TryParse(Console.ReadLine(),out int num02))
            //{
            //    Console.WriteLine(num02);
            //}

            //num02 = 20;


            //bool result = !int.TryParse(Console.ReadLine(), out int num01);
            //if (!int.TryParse(Console.ReadLine(), out int num01))
            //{
            //    int y = 3;
            //    Console.WriteLine(num01);
            //}
            //Console.WriteLine(y);
            ////num01 = 2;

            #endregion

            #region arrays
            #region one D array
            //int[] numbers;
            ///// declare reference of type array of integer
            ///// referring to null => default value of reference datatype [null]
            ///// 4 bytes will be allocated in stack => CLR 
            ///// zero bytes will be allocated in heap => CLR

            //numbers = new int[5];
            ///// CLR allocate 20 byte [5 items * 4 byte] in heap
            ///// intialized with default value of int [0]

            ////numbers = new int[5] { 1, 2, 3, 4, 5 };
            ////numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            ////int[] numbers02 = { 1, 2, 3, 4, 5, 6, 7 }; // new int[7]{ 1, 2, 3, 4, 5, 6, 7 }

            ////Console.WriteLine($"size of array: {numbers.Length}"); //size of array

            ////numbers[4] = 1;
            ////numbers[5] = 2;

            /////[quiz] write a protictive program to read elements of array from user

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Please enter the {i + 1} element of array:");
            //    }while(!int.TryParse(Console.ReadLine(), out numbers[i]));
            //}

            ////foreach (int i in numbers) //not valid
            ////{
            ////    int.TryParse(Console.ReadLine(), out item);
            ////}


            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Two D Array [Rectangular]
            //int[,] Marks;
            //Marks = new int[3,5]; //rows,column
            //Console.WriteLine($"the size of array = {Marks.Length}, the number of dimensions = {Marks.Rank}");
            //Console.WriteLine($"number of rows = {Marks.GetLength(0)} , number of column {Marks.GetLength(1)}");

            ///read elments of arry from user 
            ///print elemnts of arry to user
            ///write program to do that with protictive code and readable messages

            //for (int i = 0; i < Marks.GetLength(0); i++) //0,1,2
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++) //0,1,2,3,4
            //    {
            //        //[0,0] [0,1] [0,2] [0,3] [0,4]
            //        //[1,0] [1,1] [1,2] [1,3] [1,4]
            //        //[2,0] [2,1] [2,2] [2,3] [2,4]
            //        do
            //        {
            //            Console.WriteLine($"Please enter [{i},{j}] element");
            //        } while (!int.TryParse(Console.ReadLine(), out Marks[i, j]));

            //    }
            //}


            // [quiz] write same program with only one loop
            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    int row = i / Marks.GetLength(1);
            //    int column = i % Marks.GetLength(1);
            //    do
            //    {
            //        Console.WriteLine($"Please enter [{row},{column}] element");
            //    } while (!int.TryParse(Console.ReadLine(), out Marks[row, column]));

            //}


            //foreach (int item in Marks)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Two D Array [jagud array]
            //int[][,] numbers;
            //numbers = new int[3][,];

            //numbers[0] = new int[3, 5];
            //numbers[1] = new int[1, 3];
            //numbers[2] = new int[2, 1];

            //Console.WriteLine($"the size of array = {numbers.Length}, the number of dimensions = {numbers.Rank}");
            //Console.WriteLine($"the size of array = {numbers[0].Length}, the number of dimensions = {numbers[0].Rank}");
            //Console.WriteLine($"number of rows = {numbers[0].GetLength(0)} , number of column {numbers[0].GetLength(1)}");

            //for (int i = 0; i < numbers.Length; i++) // 0 , 1 , 2
            //{
            //    for (int j = 0; j < numbers[i].GetLength(0); j++)
            //    {
            //        for (int k = 0; k < numbers[i].GetLength(1); k++)
            //        {
            //            //numbers[i][j, k] = 10;

            //            do
            //            {
            //                Console.WriteLine($"Please enter [{i}][{j},{k}] element");
            //            } while (!int.TryParse(Console.ReadLine(), out numbers[i][j, k]));
            //        }
            //    }
            //}

            //for (int i = 0; i < numbers.Length; i++) // 0 , 1 , 2
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        int row = j / numbers[i].GetLength(1);
            //        int column = j % numbers[i].GetLength(1);

            //            do
            //            {
            //                Console.WriteLine($"Please enter [{i}][{row},{column}] element");
            //            } while (!int.TryParse(Console.ReadLine(), out numbers[i][row, column]));

            //    }
            //}

            //foreach (int[,] item in numbers)
            //{
            //    foreach (int inneritem in item)
            //    {
            //        Console.WriteLine(inneritem);
            //    }
            //}

            #endregion
            #region Array Methods
            //int[] numbers = { 8, 3, 4, 5, 6, 7, 9, 7, 1, 3, 8 };
            #region 1. calss member method
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers);
            //Console.WriteLine(Array.IndexOf(numbers, 7)); //find first index
            //Console.WriteLine(Array.LastIndexOf(numbers, 7)); //find last index
            //Console.WriteLine(Array.IndexOf(numbers, 10)); //find first index
            //Console.WriteLine(Array.LastIndexOf(numbers, 10)); //find last index
            #endregion
            #region 2. object member method
            //int[] newarr = new int[7];
            //numbers.CopyTo(newarr, 0);

            //int[] dest = new int[numbers.Length];
            //numbers.CopyTo(dest, 0);

            //Array.CreateInstance(typeof(int),10); //int[] arr = new int[10];

            //var dest01 = Array.CreateInstance(numbers.GetType().GetElementType(), numbers.Length);
            //Console.WriteLine(numbers.GetType().GetElementType());
            //numbers.CopyTo(dest01, 0);

            //numbers[5] = 18;
            //numbers.SetValue(18, 5);
            #endregion
            //foreach (int i in dest) { Console.WriteLine(i); }


            ///Ex01: write a program find the longest distance between 
            ///Two equal cells.
            ///In this example.The distance is 
            ///measured by the number Of cells- for example

            #endregion
            #endregion

            #region boxing vs  unboxing
            //Print(10);
            //Print('t');
            //Print(true);
            //Print(DateTime.Now);

            //int x = 10;
            //int y = x;
            //object obj = x; //implicit casting => boxing => vlaue type to reference type
            //parent = child; 
            //animal = dog;
            //animal = cat;
            //dog =(dog) animal; //explicit casting

            //object[] data = new object[3];
            //data[0] = 10;
            //data[1] = 3200.50m;
            //data[2] = "test"; //not boxing 

            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add(true);
            //list.Add("test");

            //int x =(int) list[0]; //int = object; => child = parent;
            //double y =(double) list[0]; //unboxing => int = object; => child = parent; 


            //int a = 10;
            //double b = a; //implicit casting
            //Console.WriteLine(b);

            //List<int> list = new List<int>();
            //list.Add(10);

            //int x = list[0];


            //object O1 = new object();
            //O1 = "string"; //not boxing

            //O1 = 5;    // int[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 'A';  // char[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 3.3;  // double[ValueType] to object[ReferenceType] -> Boxing
            //O1 = true; // bool[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateTime();  // DateTime[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateOnly(); // DateOnly[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new TimeOnly(); // TimeOnly[ValueType] to object[ReferenceType] -> Boxing
            #endregion

            #region Nullable types
            //int age = null; //not valid
            //int age = 0;
            //int? age01 = null;
            //double? age02 = null;

            //int x = 8;
            //int? y = x; //implicit casting
            //y = null;
            ////x =(int) y; //explicit casting

            //if (y is not null)
            //    x = (int)y;

            //if (y.HasValue)
            //    x = y.Value;

            //x = y.HasValue ? y.Value : 0;

            //x = y ?? 0;

            //notify
            //string t = "test";
            //t = null;

            //string? tt = "test";
            //tt = null;

            //Point p1 = new Point();
            //p1 = null!; //null forgiven
            //p1 = new Point();
            //p1 = null;
            #endregion

            #region null operator
            //int x = default; //0
            //int[] arr = default; //null

            //int length = arr.Length; //runtime error

            //if (arr is not null)
            //{
            //    length = arr.Length;
            //}

            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {

            //    }
            //}

            //for (int i = 0; arr is not null && i < arr.Length; i++)
            //{

            //}

            //int? length = arr?.Length; //null propegation
            ////arr?.length => if array is null value will be null

            ////int length02 = arr?.Length is null ? 0 : arr.Length;
            //int length02 = arr?.Length ?? 0 ; //null colascing

            //employee?.department?.name ?? "N/A";
            #endregion

            #region Function
            ////Program.PrintLine01();
            //PrintLine01();


            //Program p1 = new Program();
            //p1.PrintLine();


            //PrintLine(20, "$"); // passing by postion
            //PrintLine(pattern: "$", number: 20); //passing by name
            //PrintLine(20); //invalid

            //printline with default value of parmeters
            PrintLine();
            PrintLine(20);
            PrintLine(pattern: "$");
            PrintLine(20, "$");

            #endregion
        }

        #region Function
        //print line of 10 element of "#";

        ///// <summary>
        ///// function to print line of 10 element of "#"
        ///// object memeber method
        ///// </summary>
        //public void PrintLine()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("#");
        //    }
        //}

        ///// <summary>
        ///// function to print line of 10 element of "#"
        ///// class memeber method
        ///// </summary>
        //public static void PrintLine01()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("#");
        //    }
        //}


        //print line of number inserted by user and pattern inserted by user
        /// <summary>
        /// function to print line of number inserted by user and pattern inserted by user
        /// </summary>
        /// <param name="number">is count of rebbeted pattern</param>
        /// <param name="pattern">is pattern to print</param>
        //public static void PrintLine(int number,string pattern)
        //{
        //    for (int i = 1; i <= number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //}

        public static void PrintLine(int number = 10, string pattern = "#")
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(pattern);
            }
        }
        #endregion

        //static void Print(object input)
        //{
        //    Console.WriteLine(input);
        //}
    }

    class test
    {
        void dosomecode()
        {
            Program p1 = new Program(); //create object from type
            p1.PrintLine();

            Program.PrintLine01();
        }
    }
}
