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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void cbCadTipoClienteCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Habilite os campos "nome da empresa" caso seja uma pessoa Juridica
            if (cbCadTipoClienteCad.Text == "Pessoa Física")
            {
                lblCadCPF.Visible = true;
                mskCadCpf.Visible = true;
            }
            else
            {
                lblCadCPF.Visible = false;
                mskCadCpf.Visible = false;
            }

            if (cbCadTipoClienteCad.Text == "Pessoa Jurídica")
            {
                lblCadNomeEmpresa.Visible = true;
                txtCadNomeEmpresa.Visible = true;

                lblCnpj.Visible = true;
                mskCNPJ.Visible = true;
            }
            else
            {
                lblCadNomeEmpresa.Visible = false;
                txtCadNomeEmpresa.Visible = false;

                lblCnpj.Visible = false;
                mskCNPJ.Visible = false;
            }
        }

        private void mskCadTelFix_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCadTelFix_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Verificar se char = numero
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            #endregion
        }

        private void mskCadTelCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Verificar se char = numero
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            #endregion
        }

        private void mskCadCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Verificar se char = numero
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            #endregion
        }

        private void mskCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Verificar se char = numero
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            #endregion
        }

        private void txtCadNomeClienteCad_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
