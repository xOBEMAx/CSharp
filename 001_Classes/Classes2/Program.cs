using System;

// Классы.

// Использование методов доступа к закрытым полям.

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public void SetField(string value) // setter
        {
            field = value;
        }

        public string GetField()           // getter
        {
            return field;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello world!");

            string @string = instance.GetField();

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
