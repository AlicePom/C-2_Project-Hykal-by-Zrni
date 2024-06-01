using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_Project_Hykal
{
    public class Text : Melody // class Text inherits the Dictionary toneLength (necessary for Thread pausing) and the Pause() method from the class Melody
    {
        // A method that displays a particular syllable
        private void DisplaySyllable(string syllable, string length)
        {
            Console.Write(syllable);
            Thread.Sleep(toneLength[length] + toneLength["sixteenth"]);
        }

        // A method that displays the text
        public void DisplayText()
        {
            //// Guitar solo
            //Console.WriteLine("ZRNÍ - HÝKAL");
            //Console.WriteLine();

            //Console.WriteLine("(Playing the guitar solo...)");

            //Pause(8 * 16);
            //Console.Clear();

            // Singing
            Console.WriteLine("ZRNÍ - HÝKAL");

            Console.WriteLine();
            DisplaySyllable("Les", "quarter");
            Pause(16); // 2 * 8/8 bar pause

            Console.WriteLine();
            DisplaySyllable("O-", "eighth");
            DisplaySyllable("bý-", "3eighth");
            DisplaySyllable("va-", "eighth");
            DisplaySyllable("ný ", "3eighth");
            Pause(1); // 1/8 bar pause
            DisplaySyllable("mra-", "eighth");
            DisplaySyllable("ven-", "quarter");
            DisplaySyllable("ci, ", "quarter");
            Pause(15); // 8/8 + 7/8 bar pause
            DisplaySyllable("co ", "eighth");
            DisplaySyllable("že-", "eighth");
            DisplaySyllable("rou ", "3eighth");
            DisplaySyllable("lids-", "eighth");
            DisplaySyllable("ké ", "3eighth");
            DisplaySyllable("ma-", "eighth");
            DisplaySyllable("so", "eighth");
            Pause(6); // 6/8 bar pause

            Console.WriteLine();
            DisplaySyllable("O-", "eighth");
            DisplaySyllable("bý-", "quarter");
            DisplaySyllable("va-", "eighth");
            DisplaySyllable("ný ", "quarter");
            DisplaySyllable("mra-", "eighth");
            DisplaySyllable("ven-", "quarter");
            DisplaySyllable("ci, ", "eighth");
            Pause(5); // 5/8 bar pause
            DisplaySyllable("co ", "eighth");
            DisplaySyllable("že-", "eighth");
            DisplaySyllable("rou ", "3eighth");
            DisplaySyllable("zlé ", "quarter");
            DisplaySyllable("li-", "eighth");
            DisplaySyllable("di", "eighth");
            Pause(8); // 8/8 bar pause

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                DisplaySyllable("Dej ", "quarter");
                DisplaySyllable("si ", "eighth");
                DisplaySyllable("po-", "eighth");
                DisplaySyllable("zor ", "eighth");
                Pause(1); // 1/8 bar pause
                DisplaySyllable("na ", "eighth");
                DisplaySyllable("les, ", "eighth");
                Pause(1); // 1/8 bar pause
                DisplaySyllable("ať ", "eighth");
                DisplaySyllable("tě ", "eighth");
                DisplaySyllable("ne-", "eighth");
                DisplaySyllable("spolk-", "quarter");
                DisplaySyllable("ne ", "eighth");

                if (i < 2)
                {
                    Pause(1); // 1/8 bar pause
                }
            }

            for (int i = 0; i < 2; i++)
            {
                DisplaySyllable("hý-", "quarter");
                DisplaySyllable("kal", "eighth");

                if (i < 1)
                {
                    Pause(5); // 5/8 bar pause
                    Console.WriteLine();
                }
            }

            Pause(1); // 1/8 bar pause
            DisplaySyllable(" a ", "eighth");
            DisplaySyllable("ru-", "eighth");
            DisplaySyllable("dý ", "quarter");
            DisplaySyllable("vřes", "eighth");

            Console.WriteLine();
            Pause(8); // 8/8 bar pause
        }
    }
}
