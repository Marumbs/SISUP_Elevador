using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISUP_Elevador
{
    static class Program
    {
         static int andares => 5;
        /// <summary>
        /// Ponto de entrada principal sera que foi?
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var controle = new ControleElevador(andares);
            Console.WriteLine("Digite 0 para sair a qualquer momento");
            Console.WriteLine($"O predio possui {andares} andares");

            controle.IniciarElevador();
        }
    }
}