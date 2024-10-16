using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sibenice
{
        public class Sibenice
    {
        /// <summary>
        /// List pro vylosovani nahodneho slova
        /// </summary>
        /// <returns></returns>
        
        readonly List<string> slova = new () { "IT", "LES", "AHOJ", "STROM", "SEŠITY" };
        public List<string> zadanaPismena = new List<string>();

        /// <summary>
        /// Vytvoří paměťové místo pro promenne.
        /// </summary>
        /// <returns></returns>

        char[] rozdelSlovo;
        char[] znaky;        
        public char tip;
        public string slovo;
        public string zapisZnak;
        public string novyZnak;
        public int zivoty;
        public int okTip;

        
        public Sibenice()
        {
            /// <summary>
            /// Deklarace promennych.
            /// </summary>
            /// <returns></returns>
            
            rozdelSlovo = new char[1];
            znaky = new char[1];            
            zapisZnak = string.Empty;
            novyZnak = string.Empty;
            slovo = "";
            zivoty = 0;
            okTip = 0;
        }

        /// <summary>
        /// Generovani nahodneho slova
        /// </summary>
        /// <returns></returns>
        public string losuj()
        {
            Random random = new Random();

            int poradi = random.Next(slova.Count);
            slovo = slova[poradi];

            rozdelSlovo = slovo.ToCharArray();

            return slovo;            
        }
        /// <summary>
        /// Vypise pottrzitka podle delky slova.
        /// </summary>
        /// <returns></returns>
        public string vypsatZnaky()
        {
            znaky = new char [slovo.Length];

            for (int i = 0; i < znaky.Length; i++)
            {
                znaky[i] = '_';                
            }
            zapisZnak = string.Join(" ", znaky);
          
            return zapisZnak;            
        }
        /// <summary>
        /// Porovnani tipnuteho pismena s pismenem ve slove 
        /// a zapsani na misto podtrzitka
        /// </summary>
        /// <returns></returns>
        public string porovnej(char tip)
        {
            {                
                if (!zadanaPismena.Contains(tip.ToString()))
                    {
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        if (rozdelSlovo[i] == tip)
                        {
                            znaky[i] = tip;
                            if (slovo.Length != okTip)
                            {
                                okTip += 1;
                                zadanaPismena.Add(tip.ToString());
                            }
                        }
                    }
                }
            }

            novyZnak = string.Join(" ", znaky);

            if ((slovo.Length != okTip) && (zivoty < 11))
            {
                if (!slovo.Contains(tip))
                    zivoty += 1;
            }

            return novyZnak;
        }

    }
}
