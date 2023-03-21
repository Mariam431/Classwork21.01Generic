namespace Classwork21._01GenericEvent
{
    internal class Program
    {
        public class GenericClass<T> { }
        public class GenericClass1<T> 
        {
            public void Meth(T t)
            {
                T a = t ;
                Console.WriteLine(a);

            }   
        }

        static void Main(string[] args)
        {
            GenericClass1<string> a = new GenericClass1<string>();
            a.Meth("hey");
        }
    }
}