class musica{
    public string nome;
    public string artista;
    public int duracao;
    public bool elegivel;

    public void exibirFixaTecnica(){
        System.Console.WriteLine($"Nome: {nome}");
        System.Console.WriteLine($"Artista: {artista}");
        System.Console.WriteLine($"Duração: {duracao}");
        
        if(elegivel){
            System.Console.WriteLine("Musica disponível no plato atual.");
        }else
        {
            System.Console.WriteLine("Infelizmente esta música não está disponível no plano atual.\nContrate o plano ScreenSound Plus.");
        }
    }
};