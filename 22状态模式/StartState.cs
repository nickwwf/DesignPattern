using System;
using System.Collections.Generic;
using System.Text;

namespace _22状态模式
{
    public class StartState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Start State";
        }
    }

    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
