using System.Security.Cryptography.X509Certificates;

namespace sibenice
{
    /// <summary>
    /// Pri vyhre zapsani jmena viteze.
    /// </summary>
    /// <returns></returns>
    public partial class Nick : Form
    {
        Form1 form1;

        public string jmeno = "";
        string noveJmeno = "";
        public Nick(Form1 form1)
        {
            InitializeComponent();      
            this.form1 = form1;
        }

        private void potvrditJmenoButton_Click(object sender, EventArgs e)
        {
            noveJmeno = nickTextBox.Text;

            jmeno = noveJmeno + " - počet chyb: "; 
            
            this.Close();
        }
    }
}
