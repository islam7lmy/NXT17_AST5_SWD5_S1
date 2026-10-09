using Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman01
{
    public class TypeC
    {
        void test()
        {
            rank r = rank.first;
            TypeA a = new TypeA();
            //a.x = 10;// invalid because x is private in typeA
            a.y = 20;// valid because y is internal in typeA
            a.z = 30;// valid because z is public in typeA
        }
    }
}
