using System;

namespace SISUP_Elevador
{
    public class ElevadorSubindo : Estado
    {
        private readonly int _andar;

        public ElevadorSubindo(int andarDesejado, Estado estado)
            : this(estado.andarAtual, estado.Controle, estado.Elevador)
        {
            _andar = andarDesejado;
        }

        private ElevadorSubindo(int andarAtual, bool[] controle, ControleElevador elevador)
        {
            _andar = andarAtual;
            Controle = controle;
            Elevador = elevador;
        }

        //Tem alguns IF's que da pra remover, por que estou fazendo a logica como se fosse um input e n�o o botao
        public override string MovimentarElevador()
        {
            var mensagem = string.Empty;

            //Este if pode remover qnd terminar a GUI e o input sera pelo botao clicado
            if (_andar < 1 || _andar > Elevador.obterAndares())
                return "Andar inv�lido.";

            for (int i = andarAtual; i <= 1; i++)
            {
                if (Controle[i])
                {
                    mensagem = AndarDesejado(_andar);
                    Elevador.estadoAtual = new ElevadorParado(this);
                    break;
                }
                else
                    continue;
            }

            return mensagem ?? "Andar n�o encontrado!";
        }
    }
}
