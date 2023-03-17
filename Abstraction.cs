using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_with_oops
{
   public abstract class Abstraction
    {
        public abstract void method();

        public void method2() 
        {
            Console.WriteLine("Yes");
        }
    }
    public class abc : Abstraction
    {
        public override void method()
        {
            Console.WriteLine("Overridden");
        }
    }
}
