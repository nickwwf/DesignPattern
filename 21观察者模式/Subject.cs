﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _21观察者模式
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
