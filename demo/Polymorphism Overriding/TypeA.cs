using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Polymorphism_Overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        //Automatic Property
        //Compiler will generate hidden Private atrribute [Backing field]

        public TypeA(int a)
        {
            A = a;
        }

        //Creating object member func (Nonstatic)
        public void MyFunc01() {
            Console.WriteLine($"I Am Base [Parent]");
        }
        public virtual void MyFunc02()
        {

            Console.WriteLine($"TypeA : A= {A}");

        }
    }
}
