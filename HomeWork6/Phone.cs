using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork6
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
}
