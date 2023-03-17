using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_with_oops
{
    public class Polymorphism
    {
        //public string Concept = "Oops";

        public virtual void Oops() 
        {
            Console.WriteLine("The concepts of opps are :");
        }
    }
    class innherit
    {
        public  void Oops()
        {
            Console.WriteLine("Inheritance");
        }
    }
    class Poly
    {
        public void Oops()
        {
            Console.WriteLine("Polymorphism");
        }
    }
}
