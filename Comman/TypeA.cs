using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// class
    /// struct
    /// interface
    /// delegate
    /// record

    /// What You Can Write Inside The Enum?
    /// only labels => refer to numirc

    /// What You Can Write Inside The Class Or Struct?
    /// variables => field [attributes]
    /// functions => methods
    /// constructor
    /// events
    /// properties
    /// indexers

    /// What You Can Write Inside The Interface?
    /// method signature
    /// properties signature
    /// indexers signature
    /// events signature
    /// default implementation of methods, properties, events, and indexers (from C# 8.0 onwards)

    /// Allowed Access Modifiers Inside The Namespace 
    /// internal [default]
    /// public 

    enum rank { first, seconed, third }


    public class TypeA
    {
        /// Allowed Access Modifiers Inside The class
        ///private [default]
        ///private protected => inhertance
        ///protected         => inhertance
        ///internal
        ///internal protected=> inhertance
        ///public

        int x; //private => allow to access by class memebers only

        internal int y;//internal => allow to access by class memebers and same assemply only

        public int z;//public => allow to access by class memebers and same assemply and other assemply


        void test()
        {
            rank r = rank.first;

            x = 10;
            y = 20;
            z = 30;
        }
    }
}
