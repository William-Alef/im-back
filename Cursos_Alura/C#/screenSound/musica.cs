class Musica{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Elegivel { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence a banda/artista {Artista}.";
    public void exibirFixaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} segundos de duração");
        
        if(Elegivel){
            System.Console.WriteLine("Musica disponível no plato atual.");
        }else
        {
            System.Console.WriteLine("Infelizmente esta música não está disponível no plano atual. Contrate o plano ScreenSound Plus.");
        }
        Console.WriteLine("");
    }
};

