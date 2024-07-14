using System.Diagnostics;

namespace Homework6
{
    internal class Program
    {
        static void Main()
        {
            var phones = new[] {
                new Phone("Samsung Mustang", 79998887766, 200),
                new Phone("iPhone 55", 79999999999),
                new Phone()
            };

            foreach (var phone in phones)
            {
                phone.Info();
            }

            phones[0].receiveCall("Витёк стройка", 79421442042);

            var friendNumbers = new[]
            {
                "79421442042",
                "79321479046"
            };

            phones[1].sendMessage(friendNumbers);
        }
    }

    class Phone
    {
        private string model;
        private ulong number;
        public uint weight { get; private set; }

        public Phone(string model, ulong number, uint weight) : this(model, number)
        {
            this.weight = weight;
        }

        public Phone(string model, ulong number)
        {
            this.model = model;
            this.number = number;
        }

        public Phone()
        {
            model = "Unknown";
            number = 0;
            weight = 0;
        }

        public void Info()
        {
            var formatedNumber = string.Format($"{number:+# (###) ###-##-##}");

            Console.WriteLine(
                $"Model: {model}\n" +
                $"Number: {formatedNumber}\n" +
                $"Weight: {weight}g\n");
        }

        public void receiveCall(string name)
        {
            Console.WriteLine($"Вызов от {name}\n");
        }

        public void receiveCall(string name, ulong number)
        {
            var formatedNumber = string.Format($"{number:+# (###) ###-##-##}");

            Console.WriteLine($"Вызов от {name}\n" +
                $"{formatedNumber}\n");
        }

        public void sendMessage(params string[] numbers)
        {
            string formatedNumber;
            foreach (var number in numbers)
            {
                formatedNumber = string.Format($"{number:+# (###) ###-##-##}");

                Console.WriteLine(formatedNumber);
            }

            Console.WriteLine();
        }
    }
}