using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Orientado_objetos
{
    class olho
    {
        // Atributos
        public string Cor { get; set; }
        public string Estado { get; set; }

        // Ações

        public void abrir_olho()
        {
            Estado = "O";
        }
        
        public void fechar_olho()
        {
            Estado = "__";
        }

        public void piscar_olho()
        {
            fechar_olho();
            abrir_olho();
        }

        public olho()
            {
                  Estado = "__";
                  Cor = "Castanho";
            }
    }
}
