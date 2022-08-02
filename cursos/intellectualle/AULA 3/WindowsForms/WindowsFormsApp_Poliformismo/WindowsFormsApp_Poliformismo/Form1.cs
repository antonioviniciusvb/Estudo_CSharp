using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp_Poliformismo
{
    public partial class Form1 : Form
    {

        // método para o beep
        [DllImport("kernel32.dll")]

        public static extern bool Beep(UInt32 frequency, UInt32 duration);



        // classe abstrata

        public abstract class Campanhia
        {
            public abstract void Musica();

            public void soar()
            {
                Musica();
            }
        }


        public class Campanhia1 : Campanhia
        {
            public override void Musica()
            {
                Beep(60, 200);
                Beep(200, 200);
                Beep(110, 100);
                Beep(300, 400);
                Beep(700, 200);
                Beep(500, 1150);

            }
        }

        public class Campanhia2 : Campanhia
        {
            public override void Musica()
            {
                Beep(1000, 200);
                Beep(110, 100);
                Beep(300, 400);
                Beep(800, 200);
                Beep(500, 150);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Campanhia camp1 = new Campanhia1();

            camp1.soar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Campanhia camp2 = new Campanhia2();

            camp2.soar();
        }
    }
}
