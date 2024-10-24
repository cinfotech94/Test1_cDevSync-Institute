using test;

namespace AnotherAssembly
{
    public class Class1: BasedOnAccessibilty
    {
        public void tMainTest()
        {
            AccesFromSameAsemlyAndDerivedClassInAnotherAssembly();
            AccesWithinSameClassAndDerivedClass("i love you");
        }
        public void test()
        {
            BasedOnAccessibilty basedOnAccessibilty = new BasedOnAccessibilty();
            basedOnAccessibilty.AccessEverywhere();
           

        }
    }
}
