using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST_API2;

namespace TEST_API22
{
    public class Test2
    {
    }

    public class Lab : Dog
    {
        public int LabName { get; set; }

        public override string Foo()
        {
            return "Lab";
            //lab.TeethCount = 4;
        }
    }
}
