using System;
using System.Collections.Generic;
using System.Text;

namespace _25模板模式
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        public void Play()
        {
            //初始化游戏
            Initialize();

            //开始游戏
            StartPlay();

            //结束游戏
            EndPlay();
        }
    }
}
