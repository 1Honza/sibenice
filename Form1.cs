using sibenice.Properties;
using System.Security.Cryptography.X509Certificates;

namespace sibenice
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Vytvo¯Ì pamÏùovÈ mÌsto pro objekty.
        /// </summary>
        /// <returns></returns>
        
        public Sibenice sibenice;
        public Skore skore;

        public char tip;
        
        public Form1()
        {
            InitializeComponent();

            /// <summary>
            /// Promenne se naplnÌ objektem trÌdy typu Sibenice a Skore.
            /// </summary>
            /// <returns></returns>

            sibenice = new Sibenice();
            skore = new Skore(this);         
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            sibenice.losuj();
            labelHledaneSlovo.Text = sibenice.vypsatZnaky();
            skore.NactiPolozky();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {            
            sibenice.losuj();
            sibenice.novyZnak = sibenice.vypsatZnaky();
            labelHledaneSlovo.Text = sibenice.novyZnak;
            sibenice.zivoty = 0;
            sibenice.okTip = 0;
            pictureBoxSibenice.Image = null;
            labelPocetChyb.Text = sibenice.zivoty.ToString();
            tipniButton.Visible = true;
        }

        private void tipniButton_Click(object sender, EventArgs e)
        {

            string pismeno = " ";

            if (tipTextBox.Text != "")

            {
                pismeno = tipTextBox.Text.ToUpper();

                if (sibenice.zivoty < 11)
                {
                    tip = char.Parse(pismeno);
                    sibenice.porovnej(tip);
                }  

                labelHledaneSlovo.Text = sibenice.novyZnak;
                labelPocetChyb.Text = sibenice.zivoty.ToString();

                if ((!sibenice.slovo.Contains(tip)) && (sibenice.okTip < sibenice.slovo.Length))
                {
                    pictureBoxSibenice.Image = Image.FromFile(@"Resources\" + sibenice.zivoty + ".png");
                }
            }
            else
                MessageBox.Show("nezadal jsi pismeno");
                                    
            tipTextBox.Text = "";
            tipTextBox.Focus();

            if (sibenice.zivoty == 11)
            {
                MessageBox.Show("GAME OVER \n\n" + 
                    "Hledane slovo bylo: " + sibenice.slovo);
                tipniButton.Visible = false;
            }

            if (sibenice.slovo.Length == sibenice.okTip)
            {
                MessageBox.Show("WINNER");
                tipniButton.Visible = false;
                sibenice.zadanaPismena.Clear();
                skore.pridejJmeno();
            }                            
        }

        private void nejlepsiButton1_Click(object sender, EventArgs e)
        {
            skore.seznamOsob.Show();
        }
    }
}