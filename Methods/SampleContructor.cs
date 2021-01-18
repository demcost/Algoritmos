using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SampleContructor
    {
        public static int instanceCount;
        static object _lock = new object();

        public SampleContructor()
        {
            //lock(_lock)
            //{
            //    instanceCount++;
            //}
        }

        public SampleContructor(int x)
        {

        }


        public SampleContructor(int x, int y)
        {

        }

        //~SampleContructor()
        //{
        //    lock (_lock)
        //    {
        //        instanceCount--;
        //    }
        //}

        public int x = 0;

        public SampleContructor GetCopy()
        {
            return (SampleContructor)this.MemberwiseClone();
        }
    }
}
