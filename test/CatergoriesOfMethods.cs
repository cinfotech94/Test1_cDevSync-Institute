using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public static class BasedOnReturnmethods
    {


        public static void NonReturnMethod()
        {
            string a = "baba";
            string b = "iya";
            string c = a + b;
            Console.WriteLine(c);
        }
        public static string ReturnMethod()
        {
            string a = "baba";
            string b = "iya";
            string c = a + b;
            Console.WriteLine(c);
            return c;
        }
        public static bool ReturnMethod2()
        {
            string a = "baba";
            string b = "iya";
            string c = a + b;
            Console.WriteLine(c);
            return (b==a);
        }
        public static int ReturnMethod3()
        {
            int a = 1;
            int b =2;
            int c = a + b;
            Console.WriteLine(c);
            return c;
        }
    }
    //acces modifer
    public class BasedOnAccessibilty
    {
        public void AccessEverywhere()
        {
            AccesswithinitsOwnclassderivedClassWitinSameAssembly();
            Console.WriteLine();
        }
        private void AccesWithinThesameClass() //you cannot  access it outside of basedOnAccessibilktuy
        {
            Console.WriteLine();
        }
        protected void AccesWithinSameClassAndDerivedClass(string a)
        {
            string b = a + "only";
            
            Console.WriteLine(b);
        }
        internal void AccessWithinThesameAssembly()
        {
            Console.WriteLine();
        }
        protected internal void AccesFromSameAsemlyAndDerivedClassInAnotherAssembly()
        {
            Console.WriteLine();
        }
        private protected void AccesswithinitsOwnclassderivedClassWitinSameAssembly()
        {

        }
    }
    public class BasedOnParameter
    {
        public void ParameterizedMethodA( string a,string b)
        {

        }
        public void ParameterizedMethodb(string a)
        {

        }
        public void ParameterizedMethodA(IList<string> request)
        {

        }
        public void OptionalMethodA(string? a)
        {

        }
        public void DefaultParameterMethod(string a="kaka")
        {

        }
        public void Parameterless()
        {

        }
    }

    public class BasedOnMethodDefinition: BasedOnMethodDefinition2
    {
        public static void StaticMethod()
        {

        }
        public void InstanceMethod()
        {

        }

        public override void AbstractMethod()
        {

        }
        public override void VirtualMethod()
        {

        }

    }
    public abstract class BasedOnMethodDefinition2
    {
        public abstract void AbstractMethod();
        public virtual void VirtualMethod()
        {

        }
    }
    //any msatic method that have static method as is parent class is called extendion method
    public class BasedOnBehaviour
    {
        string Balance;
        public void SynchroniseMethod()
        {

        }

        public async Task<string> AsynchroniseMethod()
        {
        }
        public int RecursiveMethod(int n)
        {
            if (n == 1)
            { return 1; }
            return n * RecursiveMethod(n - 1);

        }
        public string  PureMethod(string a, string b)
        {
            return a + b;
        }
        public void InpureMethod(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
