using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;


internal class HomeWork5
{
    static void Main(string[] args)
    {
        Console.WriteLine("1:Ввести текст вручную\n" +
            "2:Прочитать текст из файла");

        switch (Console.ReadLine())
        {
            case "1":
                Action(ReadTextFromConsole());
                break;
            case "2":
                Action(ReadTextFromFile().Result);
                break;
            default:
                Console.WriteLine("Ошибка");
                break;
        }
    }

    static string ReadTextFromConsole()
    {
        Console.WriteLine("Введите ваш текст");
        string str = Console.ReadLine();
        return str;
    }

    static async Task<string> ReadTextFromFile()
    {
        string str;

        Console.WriteLine("Введите путь к файлу который нужно прочитать");
        string path = Console.ReadLine();
        path = path.Replace('\\', '/');
        path = path.Trim('"');

        using (StreamReader reader = new StreamReader(path))
        {
            str = await reader.ReadToEndAsync();
            return str;
        }
    }

    static void Action(string str)
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine($"Ваша строка {str}\n");
            Console.WriteLine("Что будем делать со строкой?");
            Console.WriteLine("1:Найти слова, содержащие максимальное количество цифр\n" +
                "2:Найти самое длинное слово и определить, сколько раз оно встретилось в тексте\n" +
                "3:Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять»\n" +
                "4:Вывести на экран сначала вопросительные, а затем восклицательные предложения\n" +
                "0:Выход");

            switch (Console.ReadLine())
            {
                case "0":
                    run = false;
                    break;
                case "1":
                    FindQuantityNumbers(str);
                    break;
                case "2":
                    FindLongestWord(str);
                    break;
                case "3":
                    ReplaceNumbersWithWords(str);
                    break;
                case "4":
                    ShowInterrogativeExclamationSentences(str);
                    break;
                default:
                    Console.WriteLine("Нет такой операции");
                    break;
            }
        }
    }

    static void FindQuantityNumbers(string str)
    {
        string[] internalStr = str.Split(' ');

        int result = 0;
        int index = 0;
        for (int i = 0; i < internalStr.Length; i++)
        {
            int countNumbers = 0;
            for (int j = 0; j < internalStr[i].Length; j++)
            {
                if (char.IsNumber(internalStr[i][j]))
                {
                    countNumbers++;
                }
                if (countNumbers > result)
                {
                    result = countNumbers;
                    index = i;
                }
            }
        }

        Console.Clear();
        Console.WriteLine($"Наибольшее колличество чисел в слове {internalStr[index]}\n");
    }

    static void FindLongestWord(string str)
    {
        string[] internalStr = str.Split(' ');
        int index = 0;


        for (int i = 0; i < internalStr.Length; i++)
        {
            if (internalStr[i].Length > internalStr[index].Length)
            {
                index = i;
            }
        }

        int count = 0;

        for (int i = 0; i < internalStr.Length; i++)
        {
            if (internalStr[i] == internalStr[index])
            {
                count++;
            }
        }

        Console.Clear();
        Console.WriteLine($"Самое длинное слово {internalStr[index]}\n" +
            $"Оно повторяется {count} раз\n");
    }

    static void ReplaceNumbersWithWords(string str)
    {
        StringBuilder stringBuilder = new StringBuilder(str);
        stringBuilder.Replace("0", "Ноль");
        stringBuilder.Replace("1", "Один");
        stringBuilder.Replace("2", "Два");
        stringBuilder.Replace("3", "Три");
        stringBuilder.Replace("4", "Четыре");
        stringBuilder.Replace("5", "Пять");
        stringBuilder.Replace("6", "Шесть");
        stringBuilder.Replace("7", "Семь");
        stringBuilder.Replace("8", "Восемь");
        stringBuilder.Replace("9", "Девять");

        Console.Clear();
        str = stringBuilder.ToString();
        Console.WriteLine($"Результат: {str}\n");
    }

    static void ShowInterrogativeExclamationSentences(string str)
    {
        Console.Clear();
        //char[] separator = {'.', '!', '?'};
        string[] internalStr = Regex.Split(str, @"(?<=[\.!\?])\s+");

        Console.Write("Вопросительные предложения: ");
        for (int i = 0; i < internalStr.Length; i++)
        {
            if (internalStr[i].Contains('?'))
            {
                Console.Write(internalStr[i] + " ");
            }
        }
        Console.WriteLine("\n");

        Console.Write("Восклицательные предложения: ");
        for (int i = 0; i < internalStr.Length; i++)
        {
            if (internalStr[i].Contains('!'))
            {
                Console.Write(internalStr[i] + " ");
            }
        }
        Console.WriteLine("\n");
    }
}
