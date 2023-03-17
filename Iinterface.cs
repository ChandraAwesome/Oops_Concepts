using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_with_oops
{
     interface Iinterface
    {
        void method1();
        //void method2();
    }

    interface Inone
    {
        void method2();
    }
    class onee : Iinterface, Inone
    {
        public void method1()
        {
            Console.WriteLine("Interface");
        }

        public void method2() { Console.WriteLine("Interface2"); }

    }
}
