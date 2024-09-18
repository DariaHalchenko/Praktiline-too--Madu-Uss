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
        IWavePlayer kusanie = new WaveOutEvent();
        private string pathToMedia;
        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            AudioFileReader file = new AudioFileReader("../../../taustamuusika.mp3");
            kusanie.Init(file);
            kusanie.Play();
        }
        public void Play(string songName)
        {
            AudioFileReader file = new AudioFileReader("../../../mängu_kaotada.mp3");
            kusanie.Init(file);
            kusanie.Play();
        }
        public void PlayEat(string songName)
        {
            AudioFileReader file = new AudioFileReader("../../../söömine.mp3");
            kusanie.Init(file);
            kusanie.Play();
        }
    }
}

