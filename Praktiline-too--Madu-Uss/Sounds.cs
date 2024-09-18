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
        IWavePlayer player = new WaveOutEvent();
        private string pathToMedia;
        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play() 
        {
            AudioFileReader file = new AudioFileReader("../../../taustamuusika.mp3");
            player.Init(file);
            player.Play();
            player.Volume = 0.3f;
        }
        public void PlayGameOver()
        {
            AudioFileReader file = new AudioFileReader("../../../mängu_kaotada.mp3");
            player.Init(file);
            player.Play();
        }
        public void PlayEat()
        {
            AudioFileReader file = new AudioFileReader("../../../söömine.mp3");
            player.Init(file);
            player.Play();
        }
    }
}

