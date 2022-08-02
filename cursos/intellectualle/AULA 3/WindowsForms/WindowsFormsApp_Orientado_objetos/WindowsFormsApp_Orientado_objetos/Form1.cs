using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Orientado_objetos
{
    public partial class Form1 : Form
    {
         rosto meu_rosto = new rosto();

        public Form1()
        {
            InitializeComponent();

            meu_rosto = new rosto();

            meu_rosto.Feliz();

            ajustar();

        }

        public void ajustar()
        {
            button1.Text = meu_rosto.olho_direito.Estado;
            button2.Text = meu_rosto.olho_esquerdo.Estado;
            button4.Text = meu_rosto.Estado;
        }

        private void btFeliz_Click(object sender, EventArgs e)
        {
            meu_rosto.Feliz();
            ajustar();
        }

        private void btTriste_Click(object sender, EventArgs e)
        {
            meu_rosto.Triste();
            ajustar();
        }

        private void btDesconfiado_Click(object sender, EventArgs e)
        {
            meu_rosto.Desconfiado();
            ajustar();
        }
    }
}
