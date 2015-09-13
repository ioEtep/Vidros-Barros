using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.I._2015
{
    public partial class frmSplash : Form
    {
        frmTelaPrincipal menu = new frmTelaPrincipal();
        public frmSplash()
        {
            InitializeComponent();
        }
        private int progress = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            

            pbSplash.Increment(1);

            if (pbSplash.Value == 100)
            {
                tmrSplash.Stop();
                menu.ShowDialog();
            }

            if(progress < 100)
            {
                progress++;
                lblLoad.Text = progress.ToString() + "% Carregando";
            }
            else
            {
                tmrSplash.Enabled = false;
            }

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
