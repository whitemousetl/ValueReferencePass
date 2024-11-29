
namespace ValueReferencePass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassByValue();
            PassByReference();
        }

        //
        private static void PassByValue()
        {
            static void ModifyValue(int a)
            {
                a = 10;
                Console.WriteLine(a);
            };

            int x = 5;
            ModifyValue(x);
            Console.WriteLine(x);
        }

        //
        private static void PassByReference()
        {

        }
    }
}
