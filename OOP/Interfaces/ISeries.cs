using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
   
    interface ISeries
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

    class SeriesByTwo : ISeries
    {
        public int Current { get; private set; }

        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesByThree : ISeries
    {
        public int Current { get; private set; }

        public void GetNext()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesBySeven : ISeries
    {
        public int Current { get; private set; }

        public void GetNext()
        {
            Current += 7;
        }

        public void Reset()
        {
            Current = 0;
        }
    }

}
