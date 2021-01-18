using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SampleContructor sampleContructor = new SampleContructor();

            SampleContructor sampleContructorCopy = sampleContructor.GetCopy();

            SampleContructor sampleContructorCopy2 = sampleContructor;

            SampleContructor sampleContructorCopy3 = new SampleContructor();


            Console.WriteLine(sampleContructor.Equals(sampleContructorCopy));
            Console.WriteLine(sampleContructor.Equals(sampleContructorCopy2));

            Console.WriteLine("Struct without call ctor: {0}", SampleStruct.X);

            Console.WriteLine("Total instances: {0}", SampleContructor.instanceCount);

            Console.ReadLine();
        }
    }
}
