using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    public interface ISeries
    {
        int Current { get; }

        void GetNext();

        ///////////////////////quiz//////////////////
        void Reset();
        //public void Reset()
        //{
        //    Current = 0;
        //}
    }

    /// not fully implmented abstract class, so we cannot create an object of this class
    public abstract class SeriesBase : ISeries
    {
        ///Access Modifiers
        ///private Protected => me and derived classes only, must be in the same assembly
        ///Protected => me and derived classes only, can be in different assembly
        ///Protected Internal => me and derived classes only, can be in different assembly, and also accessible from the same assembly


        //public int Current { get; private set; }
        //public int Current { get; private protected set; }
        //public int Current { get; protected set; }
        public int Current { get; protected internal set; }

        /// abstract method, so we cannot create an object of this class
        public abstract void GetNext();

        public void Reset()
        {
            Current = 0;
        }
    }

    public class SeriesByTwo : SeriesBase
    {
        public override void GetNext()
        {
            Current += 2;
        }
    }

    class test
    {
        void test01()
        {
            SeriesByTwo seriesByTwo = new SeriesByTwo();
            //seriesByTwo.Current = 10; //not valid because Current has protected setter
            seriesByTwo.Current = 10; //valid because Current has protected internal setter, and this class is in the same assembly
        }
    }
}
