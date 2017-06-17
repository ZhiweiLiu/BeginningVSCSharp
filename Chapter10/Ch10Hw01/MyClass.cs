using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Hw01
{
    class MyClass
    {
        public virtual string getString()
        {
            return myString;
        }

        protected string myString = "lalalala";

        public string ContainedString { set { myString = value; } }

    }
}
