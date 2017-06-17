using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Hw01
{
    class MyDerivedClass:MyClass
    {
        public override string getString()
        {
            return base.getString()+"(output from derived class)";
        }
    }
}
