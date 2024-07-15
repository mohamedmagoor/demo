using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Polymorphism_Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a , int b) :base(a)
        {
            B = b;
        }

        //Overriding by two ways
        // by using new keyword
        //by using override keyword

        //01=> using New key word
        public new void MyFunc01() {
            Console.WriteLine($"Im drevied [Child]");
        }

        public override void MyFunc02()
        {

            Console.WriteLine($"TypeB A=> {A} and B=>{B}");
        }
    }
}
