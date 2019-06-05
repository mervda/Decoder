using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Decoder
{
    public partial class Form1 : Form
    {
        public static Dictionary<char, String> morseovka = new Dictionary<char, String>()
        {
            {'A',".-"},
            {'B',"-..."},
            {'C',"-.-."},
            {'D',"-.."},
            {'E',"." },
            {'F',"..-."},
            {'G',"--."},
            {'H',"...."},
            {'a',"----"}, // nahrazuje CH
            {'I',".."},
            {'J',".---"},
            {'K',"-.-"},
            {'L',".-.."},
            {'M',"--"},
            {'N',"-."},
            {'O',"---"},
            {'P',".--."},
            {'Q',"--.-"},
            {'R',".-."},
            {'S',"..."},
            {'T',"-"},
            {'U',"..-"},
            {'V',"...-"},
            {'W',".--"},
            {'X',"-..-"},
            {'Y',"-.--"},
            {'Z',"--.."}

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormalni_Click(object sender, EventArgs e)
        {
            tbMorseovka.Text = "";

            String text = tbNormalniText.Text.ToUpper();
            if (text.Contains("CH"))
            {
                text = text.Replace("CH","a");
            }
               
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0)
                {
                    tbMorseovka.Text += "/";
                }

                char znak = text[i];
                if (morseovka.ContainsKey(znak))
                {
                    tbMorseovka.Text += morseovka[znak];
                }

            }
            
        }

        private void btnMorseovka_Click(object sender, EventArgs e)
        {
            tbNormalniText.Text = "";
            tbMorseovka.Text += "/";
            int count = 0;
            foreach (char c in tbMorseovka.Text)
                if (c == '/') count++;

            string[] hodnoty = tbMorseovka.Text.Split('/');
            for (int i = 0; i <= count; i++)
            {
                String hodnota = hodnoty[i];
                if (morseovka.ContainsValue(hodnota))
                {
                    if (!(hodnota == "----"))
                        tbNormalniText.Text += morseovka.FirstOrDefault(p => p.Value == hodnota).ToString().Substring(0, 2).Trim('[').ToLower();
                    if (hodnota == "----")
                        tbNormalniText.Text += "ch";
                }

            }


        }

        private void btnBeep_Click(object sender, EventArgs e)
        {

            foreach (char item in tbMorseovka.Text)
            {
                if (item == '.')
                {
                    System.Media.SoundPlayer soundDot = new System.Media.SoundPlayer(Properties.Resources.dot);
                    soundDot.Play();
                }
                if (item == '-')
                {
                    System.Media.SoundPlayer soundDash = new System.Media.SoundPlayer(Properties.Resources.dash);
                    soundDash.Play();
                }
            }
        }
    }
    }

