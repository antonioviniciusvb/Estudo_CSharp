using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp_Hotel
{
    public partial class FrmHotel : Form
    {
        public FrmHotel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaração de Constantes
            const double valor_diaria_a = 150, valor_diaria_b = 100, valor_diaria_c = 75, valor_diaria_d = 50;

            //Declaração de Variáveis
            double total_diarias = 0, sub_total = 0, taxa_servico = 0, total_geral = 0, consumo_interno = 0;
            int qnt_diarias = 0;

            try
            {
                qnt_diarias = int.Parse(lstQuantidadeDiarias.SelectedItem.ToString());
                consumo_interno = double.Parse(txtConsumo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro !! Verifique Dados de Entrada.");
                
            }

            if (rbtTipoA.Checked == true)
            {
                total_diarias = valor_diaria_a * qnt_diarias;
            }
            else
                if(rbtTipoB.Checked == true)
            {
                total_diarias = valor_diaria_b * qnt_diarias;
            }
            else
                if(rbtTipoC.Checked == true)
                {
                    total_diarias = valor_diaria_c * qnt_diarias;
                }
                else
                 if(rbtTipoD.Checked == true)
                {
                    total_diarias = valor_diaria_d * qnt_diarias;
                }
                 else
                 {
                     MessageBox.Show("Escolha um Tipo de Apartamento");
                 }

            if (total_diarias != 0)
            {
                // calculando os valores
                sub_total = total_diarias + consumo_interno;
                taxa_servico = sub_total * 0.1;
                total_geral = sub_total + taxa_servico;

                // mostrando os valores 
                lblTotalDiárias.Text = total_diarias.ToString();
                lblSubTotal.Text = sub_total.ToString();
                lblTaxaServico.Text = taxa_servico.ToString();
                lblTotalPagar.Text = total_geral.ToString();
                lblQuantidadeDiaria.Text = qnt_diarias.ToString();
                lblConsumoInterno.Text = consumo_interno.ToString();
            }
        }

        public void limpar()
        {
            txtHospede.Clear();// limpando as txts
            txtConsumo.Clear();


            lstQuantidadeDiarias.ClearSelected();// limpando as listas

            rbtTipoA.Checked = false;//  limpando os radio button
            rbtTipoB.Checked = false;
            rbtTipoC.Checked = false;
            rbtTipoD.Checked = false;

            // limpando as labels
            lblTotalDiárias.Text = "";
            lblSubTotal.Text = "";
            lblTaxaServico.Text = "";
            lblTotalPagar.Text = "";
            lblQuantidadeDiaria.Text = "";
            lblConsumoInterno.Text = "";


            txtHospede.Focus(); // colocando foco no txtHospede

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
    }
}
