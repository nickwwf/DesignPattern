﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _20备忘录模式
{
    public class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}
