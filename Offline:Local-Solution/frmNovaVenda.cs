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
    public partial class frmNovaVenda : Form
    {
        public frmNovaVenda()
        {
            InitializeComponent();
        }
        Double altura, comprimento, dimencao;

        private void frmNovaCompra_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtVendQtdPeca_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoProdutoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoProdutoVenda.Text == "Espelhos")
            {
                cbNomeProd.Enabled = false;
            }
        }

        private void btnVendConcluirCompra_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDimencao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            #region calcule a dimenção
            altura = Convert.ToDouble(txtAltura.Text);
            comprimento = Convert.ToDouble(txtComprimento.Text);

            dimencao = altura * comprimento;
            txtDimencao.Text = dimencao.ToString();
            #endregion
        }
    }
}
