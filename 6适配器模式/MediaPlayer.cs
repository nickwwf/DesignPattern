using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6适配器模式
{
    public interface MediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
