using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6适配器模式
{
    public class MediaAdapter : MediaPlayer
    {
        AdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            Init(audioType);
        }

        private void Init(string audioType)
        {
            var _t = audioType.ToLower();
            switch (_t)
            {
                case "vlc":
                    advancedMusicPlayer = new VlcPlayer();
                    break;
                case "mp4":
                    advancedMusicPlayer = new Mp4Player();
                    break;
            }
        }

        public void Play(string audioType, string fileName)
        {
            var _audioType = audioType.ToLower();
            if (audioType == "vlc")
                advancedMusicPlayer.PlayVlc(fileName);
            else if (audioType == "mp4")
                advancedMusicPlayer.PlayMp4(fileName);
        }
    }
}
