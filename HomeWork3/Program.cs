﻿// See https://aka.ms/new-console-template for more information


using System;

while (true)
{
    Console.Clear();
    double firstValue, secondValue;
    string action;

    Console.WriteLine("Введите число 1");
    firstValue = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите число 2");
    secondValue = double.Parse(Console.ReadLine());

    Console.WriteLine("Выберите операцию: '+' '-' '*' '/' '%'");
    action = Console.ReadLine();

    switch (action)

       {
        case "+":
            Console.WriteLine(firstValue + secondValue);
            break;

        case "-":
            Console.WriteLine(firstValue - secondValue);
            break;

        case "*":
            Console.WriteLine(firstValue * secondValue);
            break;

        case "/":
           if(secondValue == 0);
            {
                Console.WriteLine(0);
            }
            Console.WriteLine(firstValue / secondValue);
            break;
          

        case "%":
            Console.WriteLine(firstValue % secondValue);
            break;

        default:
            Console.WriteLine("Неверное действие");
            break;


        }
        Console.ReadLine();

}


