using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Learning_with_oops
{
    public class ValueType_ReferenceType
    {
        public static void Value()
        {
            string Name = "Ajay";
            Console.WriteLine(Name);
            ChangeValue(Name);

        }

        public static void ChangeValue(string Names)
        {
            Names = "Chandra";
            Console.WriteLine(Names);
        }
    }
}