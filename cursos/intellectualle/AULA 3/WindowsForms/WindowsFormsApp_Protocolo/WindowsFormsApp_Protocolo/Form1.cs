using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Protocolo
{

    public partial class Form1 : Form
    {
        public string modalidade;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declarando variáveis
            decimal quantidade = 0;
            string empresa, observacao;


            try
            {
                empresa = txtEmpresa.Text;
                quantidade = decimal.Parse(txtObservacao.Text);
                
            }
            catch(Exception)
            {
                MessageBox.Show("Erro !! Verifique Dados de Entrada.");
            }
            
            if((ckbOutros.Checked == false)&&(ckbRegAr.Checked == false)&&(ckbSimples.Checked == false))
            {
                MessageBox.Show("Escolha uma modalidade de Postagem");
            }


            grbProtocolo.Visible = true;


        }

        private void ckbOutros_CheckedChanged(object sender, EventArgs e)
        {
             
            if (ckbOutros.Checked == true)
            {
                ckbRegAr.Visible = false;
                ckbSimples.Visible = false;

                
                txtModalidade.Visible = true;
            }
            else
            {
                ckbRegAr.Visible = true;
                ckbSimples.Visible = true;

                
                txtModalidade.Visible = false;
            }
        }

        private void ckbSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSimples.Checked == true)
            {
                ckbRegAr.Visible = false;
                ckbOutros.Visible = false;
            }
            else
            {
                ckbRegAr.Visible = true;
                ckbOutros.Visible = true;
            }
  
        }

        private void ckbRegAr_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRegAr.Checked == true)
            {
                ckbSimples.Visible = false;
                ckbOutros.Visible = false;
            }
            else
            {
                ckbSimples.Visible = true;
                ckbOutros.Visible = true;
            }
         
        }

        private void txtModalidade_TextChanged(object sender, EventArgs e)
        {
           
            modalidade = txtModalidade.Text;
        }

        public void limpar()// limpando tudo
        {
            // limpando txtboxs
            txtEmpresa.Clear();
            txtModalidade.Clear();
            txtObservacao.Clear();


            // limpand checkboxs
            ckbOutros.Checked = false;
            ckbRegAr.Checked = false;
            ckbSimples.Checked = false;


            // colocando o foco no campo Empresa
            txtEmpresa.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }


 

}
