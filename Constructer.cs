using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_with_oops
{
    public class Constructer
    {
      private  string car;  //Encapsulation

        public string Car
        {
            get { return car; }
            set { car = value; }
        }


        public Constructer(string model)
        {
            car = model;
        }

        public class Animals : Inheritance_Animals
        {
            public string Breed = "white tiger";
        }
      
    }
}
