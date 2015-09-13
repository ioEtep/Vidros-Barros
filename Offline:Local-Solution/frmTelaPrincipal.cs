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
    public partial class frmTelaPrincipal : Form
    {
        #region Declarar os Formularios
        frmNovaVenda NovaCompra = new frmNovaVenda();
        frmPesquisar Pesquisar = new frmPesquisar();
        frmCadastrar Cadastrar = new frmCadastrar();
        #endregion

        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        { 
            //----------------------------------
            //adaptando o programa para a resolucao atual
            //-----------------------------------------------

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public void HideForms()
        {
            //-----------------------------
            //Escondendo os Formularios
            //--------------------------
            NovaCompra.Hide();
            Pesquisar.Hide();
            Cadastrar.Hide();
           
        }

        private void DefaultBtn()
        {
            //--------------------------------------
            // Deixar o fundo dos Botoes nas cores iniciais
            //---------------------------------

            btnMainCadastrarCliente.BackColor = Color.Transparent;
            btnNovaVenda.BackColor = Color.Transparent;
            btnMainPesquisar.BackColor = Color.Transparent;
            btnMainHelp.BackColor = Color.Transparent;
            btnWelcome.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
        }

        private void DefaultClr()
        {
            //---------------------------------
            //Cor padrao das letras dos botoes
            //-----------------------------

            btnMainCadastrarCliente.ForeColor = System.Drawing.Color.Black;
            btnMainHelp.ForeColor = System.Drawing.Color.Empty;
            btnNovaVenda.ForeColor = System.Drawing.Color.Black;
            btnMainPesquisar.ForeColor = System.Drawing.Color.Black;
            btnWelcome.ForeColor = System.Drawing.Color.Black;
            btnSair.ForeColor = System.Drawing.Color.Empty;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {//btnNovaCompra
            #region Mostrar o Formulario Principal
            HideForms();
            NovaCompra.Show();
            #endregion
            #region Alterar a Cor das Letras do botao
            DefaultClr();
            btnNovaVenda.ForeColor = System.Drawing.Color.White;
            #endregion
            #region Alterar a Cor do botao
            DefaultBtn();
            btnNovaVenda.BackColor = Color.IndianRed;
            #endregion
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            #region Mostrar o Formulario Principal
            HideForms();
            Pesquisar.Show();
            #endregion
            #region Alterar a Cor das Letras do botao
            DefaultClr();
            btnMainPesquisar.ForeColor = System.Drawing.Color.White;
            #endregion
            #region Alterar a Cor do botao
            DefaultBtn();
            btnMainPesquisar.BackColor = Color.IndianRed;
            #endregion
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            #region Mostrar o Formulario Principal
            HideForms();
            Cadastrar.Show();
            #endregion
            #region Alterar a Cor das Letras do botao
            DefaultClr();
            btnMainCadastrarCliente.ForeColor = System.Drawing.Color.White;
            #endregion
            #region Alterar a Cor do botao
            DefaultBtn();
            btnMainCadastrarCliente.BackColor = Color.IndianRed;
            #endregion
        }

        private void btnMainHelp_Click(object sender, EventArgs e)
        {
            
            #region Alterar a Cor do botao
            DefaultBtn();
            btnMainHelp.BackColor = Color.IndianRed;
            #endregion
            #region Alterar a Cor das Letras do botao
            DefaultClr();
            btnMainHelp.ForeColor = System.Drawing.Color.White;
            #endregion

        }
        private void btnWelcome_Click(object sender, EventArgs e)
        {
            
            #region Alterar a Cor do botao
            DefaultBtn();
            btnWelcome.BackColor = Color.IndianRed;
            #endregion
            #region Alterar a Cor das Letras do botao
            DefaultClr();
            btnWelcome.ForeColor = System.Drawing.Color.White;
            #endregion
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            #region Alterar a Cor do botao
            DefaultBtn();
            btnSair.BackColor = Color.IndianRed;
            #endregion
            #region Alterar a Cor das Letras do botao
            DefaultClr();
            btnSair.ForeColor = System.Drawing.Color.White;
            #endregion
            #region Mostrar o Formulario Principal
            HideForms();
            #endregion
            #region Messagebox Close
            if (MessageBox.Show("Deseja Mesmo Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
            #endregion
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpPesquisar_Enter(object sender, EventArgs e)
        {

        }

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDia.Text = DateTime.Now.ToString("ddd").Substring(0, 3);
            
        }

        private void lblDia_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin TelaLogar = new frmLogin();
            TelaLogar.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            Close();
        }

      

       

      
    }
}
