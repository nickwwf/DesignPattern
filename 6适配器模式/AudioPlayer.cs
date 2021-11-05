using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6适配器模式
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            var _t = audioType.ToLower();
            switch (_t)
            {
                case "mp3":
                    Console.WriteLine("Playing mp3 file. Name: " + fileName);
                    break;
                case "mp4":
                    mediaAdapter = new MediaAdapter(audioType);
                    mediaAdapter.Play(audioType, fileName);
                    break;
                case "vlc":
                    mediaAdapter = new MediaAdapter(audioType);
                    mediaAdapter.Play(audioType, fileName);
                    break;
                default:
                    Console.WriteLine("Invalid media. " +
            audioType + " format not supported");
                    break;
            }
        }
    }
}
