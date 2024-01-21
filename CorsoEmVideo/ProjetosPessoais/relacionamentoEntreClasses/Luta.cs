class Luta : ILuta
{
    private Lutador Desafiado {get; set;}
    private Lutador Desafiante {get; set;}
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
        if(this.Aprovada)
        {
            this.Desafiado.Apresentar();
            this.Desafiante.Apresentar();

            Random random = new Random();
            int vencedor = random.Next(0, 3);
            System.Console.WriteLine();
            switch (vencedor)
            {
                case 0: this.Desafiado.EmpatarLuta(); this.Desafiante.EmpatarLuta(); System.Console.WriteLine("A luta empatou!");
                break;
                case 1: this.Desafiado.GanharLuta(); this.Desafiante.PerderLuta(); System.Console.WriteLine($"O vencedor da luta é...\n{Desafiado.ObterNome()}!!");
                break;
                case 2: this.Desafiante.GanharLuta(); this.Desafiado.PerderLuta(); System.Console.WriteLine($"O vencedor da luta é...\n{Desafiante.ObterNome()}!!");
                break;  
            }
        }
        else
        {
            System.Console.WriteLine("A luta não pode acontecer, pois não foi aprovada.");
        }
    }
}