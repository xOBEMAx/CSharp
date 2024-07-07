using System.ComponentModel.Design;
using System.Data;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "Оплата по счёту №189 от 10.01.2022 за транспортные услуги в т. ч. НДС 20% 1564,89";

        var newStr = str.Split(' ');
        foreach (var item in newStr) 
        {
            if (item.StartsWith('№'))
            {
                Console.WriteLine(item);
            }
            if (DateOnly.TryParse(item, out var date))
            {
                Console.WriteLine(date);
            }



        }

    }
}