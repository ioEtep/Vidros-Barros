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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void frmNovaCompra_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void ClearAll()
        {
            #region Esvazie os Campos
           
            #endregion
        }

        private void RedIfEmpty()
        {
            #region Pinte os vazios
            
            #endregion
        }

        private void txtPrecoAtual_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPesqNovoPreco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnPesqPesquisar_Click(object sender, EventArgs e)
        {
            
            {
              //  MessageBox.Show("Verifique se TODOS os campos foram preenchidos corretamente",
                //    "Algo não está certo!",MessageBoxButtons.OK , MessageBoxIcon.Error);
               // RedIfEmpty();
            }

        }

        private void btnPesqClear_Click(object sender, EventArgs e)
        {
            //Tem certeza que quer Limpar Tudo?
            DialogResult msgbxResp = MessageBox.Show("Tem certeza de que deseja limpar todos os campos?", "Está Certo Disso?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
            if (msgbxResp == DialogResult.Yes)
            {
                ClearAll();
            }
        }

        private void txtPesqQtdEstoque_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPesqTipo_TextChanged(object sender, EventArgs e)
        {
            cbPesqTipo.BackColor = Color.Empty;
        }

        private void txtPesqNomePeca_TextChanged(object sender, EventArgs e)
        {
            //txtPesqNomePeca.BackColor = Color.Empty;
        }

        private void txtPesqQtdEstoque_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrecoAtual_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPesqNovoPreco_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPesqAlterar_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Verifique se TODOS os campos foram preenchidos corretamente",
                    "Algo não está certo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RedIfEmpty();
            }
        }
    }
}
