using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Praktiline_too__Madu_Uss
{
    //vastutab mängu helide taasesitamise eest (отвечает за воспроизведение звуков в игре)
    class Sounds
    {
        private IWavePlayer player = new WaveOutEvent();
        private AudioFileReader currentFile;
        private string pathToMedia;
        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        //helide taasesitamine (воспроизведения звуков)
        public void Play(string filePath)
        {
            Stop(); //Peatame jooksva reprodutseerimise (Останавливаем текущее воспроизведение)
            currentFile = new AudioFileReader(filePath);
            player.Init(currentFile);
            player.Volume = 0.3f;
            player.Play();
        }
        //mängib mängu lõppedes heli (воспроизводит звук при окончания игры)
        public void PlayGameOver()
        {
            Play("../../../mängu_kaotada.mp3");
        }
        //paljundab "söömise" heli, kui madu sööb toidu ära (воспроизводит звук "поедания", когда змейка съедает еду )
        public void PlayEat()
        {
            Play("../../../söömine.mp3");
        }
        //Peatame jooksva reprodutseerimise (Останавливаем текущее воспроизведение)
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
