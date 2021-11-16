using System;

namespace SISUP_Elevador
{
    public class ElevadorParado : Estado
    {
        public ElevadorParado(Estado estado)
            : this(estado.andarAtual, estado.Elevador)
        {
        }

        public ElevadorParado(int andarAtual, ControleElevador elevador)
        {
            andarAtual = andarAtual;
            Elevador = elevador;
            Controle = new bool[elevador.obterAndares() + 1];

            Controle[andarAtual] = true;
        }

        public override string MovimentarElevador()
        {
            Console.WriteLine("");
            Console.WriteLine($"Para qual andar você deseja ir?");

            var andarDesejado = Elevador.validateEntrada();

            if (andarAtual < andarDesejado)
            {
                Elevador.estadoAtual = new ElevadorSubindo(andarDesejado, this);
                return "Elevador subindo...";
            }
            else if (andarAtual > andarDesejado)
            {
                Elevador.estadoAtual = new ElevadorDescendo(andarDesejado, this);
                return "Elevador descendo...";
            }
            else
                return "O elevador já encontra-se no andar.";
        }
    }
}