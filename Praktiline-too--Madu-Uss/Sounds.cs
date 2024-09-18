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
        private IWavePlayer player = new WaveOutEvent();
        private AudioFileReader currentFile;
        private string pathToMedia;
        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play(string filePath)
        {
            Stop(); // Останавливаем текущее воспроизведение
            currentFile = new AudioFileReader(filePath);
            player.Init(currentFile);
            player.Volume = 0.3f;
            player.Play();
        }

        public void PlayGameOver()
        {
            Play("../../../mängu_kaotada.mp3");
        }

        public void PlayEat()
        {
            Play("../../../söömine.mp3");
        }

        public void Stop()
        {
            if (player.PlaybackState == PlaybackState.Playing)
            {
                player.Stop();
                currentFile?.Dispose(); // Освобождаем ресурсы
                currentFile = null; // Обнуляем текущий файл
            }
        }
    }
}
