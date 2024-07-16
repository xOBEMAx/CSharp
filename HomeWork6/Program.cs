using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

namespace Homework6
{
    class Phone
    {
        string Number;
        string Model;
        float Weight;

        public Phone()
        {
            Number = "Unknown number ";
            Model = " No model";
            Weight = 0;
        }

        public Phone(string userNumber, string userModel)
        {
            Number = userNumber;
            Model = userModel;
            Weight = 0;
        }
        public Phone(string userNumber, string userModel, float phoneWeight)
        {
            Number = userNumber;
            Model = userModel;
            Weight = phoneWeight;
        }

        public void ResiveCall(string Name)
        {
            Console.WriteLine($"{Name} calls");
        }

        public string GetNumber()
        {
            return Number;
        }

    }
    class Program
    {
        public static void Main()
        {
            Phone phone = new Phone();
            Phone phone1 = new Phone("+484234512", "iPhone 15");
            Phone phone2 = new Phone("+482312376", "Sumsung", 5);

            Console.WriteLine(phone.GetNumber());
            Console.WriteLine(phone1.GetNumber());
            Console.WriteLine(phone2.GetNumber());

            phone1.ResiveCall("Pavel");
        }
    }
}






//    Домашнее задание
//Основное задание
//1. Класс Phone.
//Создайте класс Phone, который содержит переменные number, model и
//weight.
//Создайте три экземпляра этого класса.
//Выведите на консоль значения их переменных.
//Добавить в класс Phone методы: receiveCall, имеет один параметр – имя
//звонящего. Выводит на консоль сообщение “Звонит { name}”. getNumber –
//возвращает номер телефона.Вызвать эти методы для каждого из объектов.
//    Добавить конструктор в класс Phone, который принимает на вход три
//параметра для инициализации переменных класса - number, model и weight.
//Добавить конструктор, который принимает на вход два параметра для
//инициализации переменных класса - number, model.
//teachmeskills.by
//Добавить конструктор без параметров.
//Вызвать из конструктора с тремя параметрами конструктор с
//двумя.
//Добавьте перегруженный метод receiveCall, который принимает два
//параметра - имя звонящего и номер телефона звонящего.Вызвать этот
//метод.
//Создать метод sendMessage с аргументами переменной длины.Данный
//метод принимает на вход номера телефонов, которым будет отправлено
//сообщение. Метод выводит на консоль номера этих телефонов.