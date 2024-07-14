using System;

namespace Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Вызван метод класса MyClass");
        }
    }

    class MyClass2
    {
        public void CallMethod(MyClass my)
        {
            my.Method();
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            MyClass2 my2 = new MyClass2();

            my2.CallMethod(my);

            Console.ReadKey();
        }
    }
}
