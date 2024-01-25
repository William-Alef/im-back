public class Gafanhoto : Pessoa
{
    private bool Logado {get; set;}
    private int QuantVideosVistos {get; set;}
    public Gafanhoto(string nome, int idade, string sexo, float experiencia, bool logado) : base(nome, idade, sexo, experiencia)
    {
        this.Logado = logado;
    }
    public void VisualizouVideo()
    {
        if(Logado)
        {
            this.QuantVideosVistos++;
        }
        else
        {
            System.Console.WriteLine("É necessário estar logado para visualizar um vídeo");
        }
    }
}