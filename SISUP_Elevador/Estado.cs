namespace SISUP_Elevador
{
    public abstract class Estado
    {
        public ControleElevador Elevador { get; set; }
        public int andarAtual { get; set; }
        public bool[] Controle { get; set; }

        public abstract string MovimentarElevador();

        public string AndarDesejado(int andar)
        {
            Controle[andarAtual] = false;
            Controle[andar] = true;
            andarAtual = andar;

            return ($"Elevador parado no andar {andar} andar");
        }
    }

}
