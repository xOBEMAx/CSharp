﻿using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
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
    }
    static void Main(string[] args)
    {
        

    }

        
}

