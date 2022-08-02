using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Orientado_objetos
{
    class rosto
    {
       public  olho olho_direito = new olho();
       public  olho olho_esquerdo = new olho();

        public string Estado { get; set; }

        // Ações

        public void Feliz()
        {
            olho_direito.abrir_olho();
            olho_esquerdo.abrir_olho();

            Estado = "(____)";
        }

        public void Triste()
        {
           olho_direito.fechar_olho();
           olho_esquerdo.fechar_olho();

            Estado = "------";
        }

        public void Desconfiado()
        {
           olho_direito.fechar_olho();
            olho_esquerdo.abrir_olho();

            Estado = "(____";
        }

        public void Rosto()
        {
             olho_direito = new olho();
             olho_esquerdo = new olho();

            Feliz();
        }
    }
}
