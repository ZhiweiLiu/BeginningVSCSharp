using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Hw04
{
    class MyCopyableClass
    {
        protected int myInt;
        public int myIntPro {
            get { return myInt; }
            set { myInt = value; }
        }
        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }
}
