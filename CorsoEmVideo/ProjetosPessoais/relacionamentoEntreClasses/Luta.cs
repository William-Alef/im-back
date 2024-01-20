class Luta : ILuta
{
    private Lutador _desafiado;
    private Lutador Desafiado 
    { 
        get => _desafiado; 
        set
        {
            _desafiado = value;
        } 
    }
    private Lutador _Desafiante;
    private Lutador Desafiante 
    {
        get => _Desafiante; 
        set 
        {
            _Desafiante = value;
        }
    }
    private int Rounds;
    private bool Aprovada;

    public void MarcarLuta(Lutador lutador1, Lutador lutador2)
    {   
        if(lutador1 != lutador2)
        {
            if(lutador1.ObterCategoria() == lutador2.ObterCategoria())
            {
                this.Aprovada = true;
                Desafiado = lutador1;
                Desafiante = lutador2;
                System.Console.WriteLine($"Luta marcada entre os lutadores {lutador1.ObterNome()} e {lutador2.ObterNome()}");
            }
            else
            {
                System.Console.WriteLine("Não é possível marcar uma luta, pois os lutadores não pertencem a mesma categoria.");
            }  
        }
        else
        {
            System.Console.WriteLine("Não é possível marcar uma luta com o mesmo lutador sendo adversario");
        }
        
    }

    public void Lutar()
    {
        if(Aprovada)
        {
            Desafiado.Apresentar();
            Desafiante.Apresentar();
            Random random = new Random();
            int nRandomico = random.Next(0, 2);

            switch (nRandomico)
            {
                case 1: Desafiado.GanharLuta(); Desafiante.PerderLuta();
                break;
                case 2: Desafiante.GanharLuta(); Desafiado.PerderLuta(); System.Console.WriteLine("");
                break;
                default: Desafiado.EmpatarLuta(); Desafiante.EmpatarLuta(); System.Console.WriteLine("A luta empatou!");
                break;
            }
        }
        else
        {
            System.Console.WriteLine("A luta não pode acontecer, pois não foi aprovada.");
        }
    }
}