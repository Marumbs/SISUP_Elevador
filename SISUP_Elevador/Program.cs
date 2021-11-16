using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISUP_Elevador
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal sera que foi?
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var controle = new ControleElevador(andares);
            Console.WriteLine("Digite 0 para sair a qualquer momento");
            Console.WriteLine($"O predio possui {andares} andares");

            controle.IniciarElevador();
        }
    }
}