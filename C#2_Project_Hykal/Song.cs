using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_Project_Hykal
{
    public class Song
    {
        public Melody melody;
        public Text text;

        public Song()
        {
            melody = new Melody();
            text = new Text();
        }

        public void StartSong()
        {
            Thread melodyThread = new Thread(melody.PlayMelody);
            Thread textThread = new Thread(text.DisplayText);

            melodyThread.Start();
            textThread.Start();

            melodyThread.Join();
            textThread.Join();
        }
    }
}
