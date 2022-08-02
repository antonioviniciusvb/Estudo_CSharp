using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculadora
{
    public partial class Form1 : Form
    {
        double total, ultimonumero;
        string operador;

        private void limpar()
        {
            total = 0;
            ultimonumero = 0;
            operador = "+";
            txtCalculadora.Clear();
        }

        private void calcular()
        {
            switch (operador)
            {
                case "+":

                    total = total + ultimonumero;
                    break;

                case "-":

                    total = total - ultimonumero;
                    break;

                case "/":

                    total = total / ultimonumero;
                    break;

                case "x":

                    total = total * ultimonumero;

                    break;
            }

            ultimonumero = 0;

            txtCalculadora.Text = total.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            total = 0;
            ultimonumero = 0;
            operador = "+";
            txtCalculadora.Text = "0";
            
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void bt_numero(object sender, EventArgs e)
        {

            if (ultimonumero == 0)
            {
                txtCalculadora.Text = (sender as Button).Text;
            }
            else
            {
                txtCalculadora.Text = txtCalculadora.Text + (sender as Button).Text;
            }

            ultimonumero = double.Parse(txtCalculadora.Text);
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            ultimonumero = double.Parse(txtCalculadora.Text);

            calcular();
            operador = "+";
            total = 0;
        }

        private void btOperador(object sender, EventArgs e)
        {
            ultimonumero = double.Parse(txtCalculadora.Text);

            calcular();
            operador = (sender as Button).Text;
        }

      
    }
}
