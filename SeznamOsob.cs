using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sibenice
{

    /// <summary>
    /// Tabulka nejlepsich hracu.
    /// </summary>
    /// <returns></returns>
    public partial class SeznamOsob : Form
    {
        public Skore skore;
        public SeznamOsob(Skore skore)
        {
            InitializeComponent();
            this.skore = skore;
        }

        private void SeznamOsob_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void vycistitButton_Click(object sender, EventArgs e)
        {
            skore.seznamHracu.Clear();
            skore.UlozPolozky();
            skore.seznamOsob.hraciListBox.DataSource = null;
            skore.seznamOsob.hraciListBox.DataSource = skore.seznamHracu;
            //File.Delete(skore.cesta);
        }
    }
}
