﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _16命令模式
{
    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] bought");
        }

        public void Sell()
        {
            Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] sold");
        }
    }
}
