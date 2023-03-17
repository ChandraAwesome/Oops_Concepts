using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning_with_oops
{
    class ReferenceType
    {
        public string value
        {
            get;
            set;
        }
        public ReferenceType(string passbyref)
        {
            this.value = passbyref;
        }
    }
    
}
