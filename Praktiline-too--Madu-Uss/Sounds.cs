using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Praktiline_too__Madu_Uss
{
    class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;
        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            player.URL = pathToMedia + "taustamuusika.mp3";
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);
        }
        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + "mängu_kaotada.mp3";
            player.controls.play();
        }
        public void PlayEat(string songName)
        {
            player.URL = pathToMedia + songName + "söömine.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}

