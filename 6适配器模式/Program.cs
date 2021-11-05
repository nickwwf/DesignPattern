using System;

namespace _6适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "爱我中华.mp3");
        }
    }
}
