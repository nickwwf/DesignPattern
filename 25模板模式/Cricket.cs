using System;
using System.Collections.Generic;
using System.Text;

namespace _25模板模式
{
    public class Cricket : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start playing.");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }
    }
}
