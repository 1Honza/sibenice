using System.Collections.Immutable;
using System.ComponentModel;
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace sibenice
{
    public class Skore
    {
        public string cesta = "SeznamOsob.xml";

        /// <summary>
        /// Ulozeni dvou parametru, jmeno hrace a jeho skore.
        /// </summary>
        /// <returns></returns>
        public List<(string Jmeno, int skore )> seznamHracu { get; set; }

        public SeznamOsob seznamOsob;

        public Form1 form1;
        public Skore(Form1 form1)
        {
            seznamHracu = new List<(string Jmeno, int skore)>();            

            seznamOsob = new SeznamOsob(this);
            this.form1 = form1;
    }

        /// <summary>
        /// Ulozeni noveho viteze do listu a sortovani dle skore.
        /// </summary>
        /// <returns></returns>
        public void pridejJmeno()

        {
            Nick nick = new Nick(form1);
            nick.ShowDialog();

            seznamHracu.Add(( nick.jmeno, form1.sibenice.zivoty));

            seznamHracu.Sort((s1, s2) => s1.skore.CompareTo(s2.skore));

            seznamOsob.hraciListBox.DataSource = null;
            seznamOsob.hraciListBox.DataSource = seznamHracu;

            seznamOsob.Show();

            UlozPolozky();
            NactiPolozky();
        }

        /// <summary>
        /// Nacteni vitezu ze souboru.
        /// </summary>
        /// <returns></returns>
        public void NactiPolozky()
        {
            if (File.Exists(cesta))
            {
                XmlSerializer serializer = new XmlSerializer(seznamHracu.GetType());

                using (StreamReader sr = new StreamReader(cesta))
                {                    
                    seznamHracu = (List<(string Jmeno, int skore )>)serializer.Deserialize(sr);
                    seznamOsob.hraciListBox.DataSource = null;
                    seznamOsob.hraciListBox.DataSource = seznamHracu;
                }
            }
            else
                seznamHracu = new List<(string Jmeno, int skore)>();
        }

        /// <summary>
        /// Ulozeni vitezu do souboru.
        /// </summary>
        /// <returns></returns>
        public void UlozPolozky()
        {
            XmlSerializer serializer = new XmlSerializer(seznamHracu.GetType());

            using (StreamWriter sw = new StreamWriter(cesta))
            {
                serializer.Serialize(sw, seznamHracu);
            }
        }       
        
    }
}
