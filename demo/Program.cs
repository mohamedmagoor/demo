using demo.Polymorphism_Overriding;

namespace demo
{
    internal class Program
    {
        #region overloading
        public static int Sum(int x, int y) {

            return x + y;

        }
        public static int sum(int x, int y, int z)
        {

            return x + y + z;

        }
        public static double sum(double x, double y)
        {
            return x + y;
        }
        public static double sum(double x, int y) {
            return x + y;

        }
        public static double sum(int x, double y)
        {
            return x + y;

        }

        #endregion
        static void Main(string[] args)
        {
            #region Polymorphism (OverLoading)
            int result = Sum(1, 2);
            Console.WriteLine(result);
            result = sum(1, 2, 3);
            Console.WriteLine(result);
            double result2double = sum(1.1, 2.2);
            Console.WriteLine(result2double);

            #endregion

            #region Polymorphism (Overriding)
            TypeA typeA = new TypeA(1);
            typeA.A = 10;
            typeA.MyFunc01();
            typeA.MyFunc02();//10

            Console.WriteLine("0000000000000000000000");
            TypeB typeB = new TypeB(1, 2);
            typeB.A = 10;
            typeB.B = 20;
            typeB.MyFunc01();
            typeB.MyFunc02();

            #endregion


            #region Binding
            // reference from parent => object from child.....
            Console.WriteLine(";;;;;;;;;;;;;");
            TypeA refbase;
            refbase = new TypeB(1, 2);
            // not refer to all object just the parent
            refbase.MyFunc01();// static binding cuz we use new keyword cpmpile time
            refbase.MyFunc02();// dynamic binding run time clr

            #endregion

            #region Not Binding
            // reference from child => object from parent

            TypeB Childref = (TypeB)new TypeA(20);//valid //not binding
            //Unsafe ---- Explict castingg
            #endregion
        }
    
    }
}
