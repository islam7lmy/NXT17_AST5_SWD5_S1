using Comman;
using Comman01;
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
            #region Employee

            #endregion
            #endregion
        }
    }
}
