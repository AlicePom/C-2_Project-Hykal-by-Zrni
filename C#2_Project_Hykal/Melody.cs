using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_Project_Hykal
{
    public class Melody
    {
        // A dictionary defining tone frequency - 2 octaves (C3 - C5)
        private Dictionary<string, int> toneFrequency = new Dictionary<string, int>
{
    { "C3", 131 },
    { "Cis3", 139 },
    { "D3", 147 },
    { "Dis3", 156 },
    { "E3", 165 },
    { "F3", 175 },
    { "Fis3", 185 },
    { "G3", 196 },
    { "Gis3", 208 },
    { "A3", 220 },
    { "B3", 233 },
    { "H3", 247 },
    { "C4", 262 },
    { "Cis4", 277 },
    { "D4", 294 },
    { "Dis4", 311 },
    { "E4", 330 },
    { "F4", 349 },
    { "Fis4", 370 },
    { "G4", 392 },
    { "Gis4", 415 },
    { "A4", 440 },
    { "B4", 466 },
    { "H4", 494 },
    { "C5", 523 },
};

        // A dictionary defining tone length
        protected Dictionary<string, int> toneLength = new Dictionary<string, int>
{
    { "whole", 3000 }, // whole tact including pauses; 8*E + 8*S (pause length)
    { "half", 1375 }, // half; 4*E + (4-1)*S (pause length)
    { "3eighth", 1000}, // 3*eighth; 3*E + (3-1)*S (pause length)
    { "quarter", 625 }, // quarter; 2*E + (2-1)*S (pause length)
    { "eighth", 250 }, // eighth; 2*S (the shortest tone within the song)
    { "sixteenth", 125 } // sixteenth; it is equal to pause length
};

        // A method that plays a particular tone
        private void PlayTone(string tone, string length)
        {
            Console.Beep(toneFrequency[tone], toneLength[length]); // tone
            Thread.Sleep(toneLength["sixteenth"]); // pause
        }

        // A method that inserts pauses between other methods
        protected void Pause(int countEighth)
        {
            Thread.Sleep((toneLength["eighth"] + toneLength["sixteenth"]) * countEighth);
        }

        // A method that plays the melody
        public void PlayMelody()
        {
            //// Guitar solo
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Pause(1); // 1/8 bar pause

            //        for (int k = 0; k < 6; k++)
            //        {
            //            PlayTone("H3", "eighth");
            //        }

            //        if (j == 1)
            //        {
            //            PlayTone("Fis4", "eighth");
            //        }
            //        else if (j == 3)
            //        {
            //            PlayTone("E4", "eighth");
            //        }
            //        else
            //        {
            //            PlayTone("D4", "eighth");
            //        }
            //    }
            //}

            // Singing
            //bar 1
            PlayTone("D4", "quarter"); // Les
            Pause(6); // 6/8 bar pause

            //bar 2
            Pause(8); // 8/8 bar pause

            //bar 3 and 4
            Pause(2); // 2/8 bar pause

            PlayTone("H3", "eighth"); // O-
            PlayTone("Fis4", "3eighth"); // bý-
            PlayTone("A3", "eighth"); // va-
            PlayTone("E4", "3eighth"); // ný

            Pause(1); // 1/8 bar pause

            PlayTone("E4", "eighth"); // mra-
            PlayTone("E4", "quarter"); // ven-
            PlayTone("D4", "quarter"); // ci

            //bar 5
            Pause(8); // 8/8 bar pause

            //bar 6
            Pause(7); // 7/8 bar pause

            PlayTone("H4", "eighth"); // co

            //bar 7
            PlayTone("H4", "eighth"); // že-
            PlayTone("Fis4", "3eighth"); // rou
            PlayTone("Fis4", "eighth"); // lids-            
            PlayTone("Fis4", "3eighth"); // ké          

            //bar 8
            PlayTone("Fis4", "eighth"); // ma-
            PlayTone("E4", "eighth"); // so

            Pause(6); // 6/8 bar pause

            //bar 9 and 10
            PlayTone("H3", "eighth"); // O-
            PlayTone("E4", "quarter"); // bý-
            PlayTone("H3", "eighth"); // va-
            PlayTone("E4", "quarter"); // ný
            PlayTone("H3", "eighth"); // mra-
            PlayTone("E4", "quarter"); // ven-
            PlayTone("H3", "eighth"); // ci

            Pause(5); // 5/8 bar pause

            PlayTone("H4", "eighth"); // co

            //bar 11
            PlayTone("H4", "eighth"); // že-
            PlayTone("Fis4", "3eighth"); // rou
            PlayTone("Fis4", "quarter"); // zlé
            PlayTone("Fis4", "eighth"); // li-
            PlayTone("E4", "eighth"); // di

            //bar 12
            Pause(8); // 8/8 bar pause

            //bar 13 - 18 (first 7/8)
            for (int l = 0; l < 3; l++)
            {
                if (l == 1)
                {
                    PlayTone("Fis4", "quarter"); // Dej
                }
                else
                {
                    PlayTone("D4", "quarter"); // Dej
                }

                PlayTone("H3", "eighth"); // si
                PlayTone("A3", "eighth"); // po-                
                PlayTone("H3", "quarter"); // zor                
                PlayTone("A3", "eighth"); // na                
                PlayTone("H3", "eighth"); // les

                Pause(1); // 1/8 bar pause

                PlayTone("A3", "eighth"); // ať                 
                PlayTone("H3", "eighth"); // tě
                PlayTone("H3", "eighth"); // ne-
                PlayTone("D4", "quarter"); // spolk-
                PlayTone("H3", "eighth"); // ne               

                if (l < 2)
                {
                    Pause(1); // 1/8 bar pause
                }
            }

            //bar 18 (last 1/8) - 20
            PlayTone("H3", "quarter"); // hý-
            PlayTone("H3", "eighth"); // kal            

            Pause(5); // 5/8 bar pause

            PlayTone("A3", "quarter"); // hý-
            PlayTone("H3", "eighth"); // kal

            Pause(1); // 1/8 bar pause

            PlayTone("H3", "eighth"); // a
            PlayTone("A3", "eighth"); // ru-
            PlayTone("H3", "quarter"); // dý
            PlayTone("H3", "eighth"); // vřes

            //bar 21
            Pause(8); // 8/8 bar pause
        }
    }
}
