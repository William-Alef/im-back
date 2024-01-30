public class Gafanhoto : Pessoa
{
    private string Login {get; set;}
    private int QuantVideosVistos {get; set;}

    public Gafanhoto(string nome, int idade, string sexo, string login) : base(nome, idade, sexo)
    {
        this.Login = login;
        this.Nome = nome;
    }

    public void VisualizouVideo()
    {
    }
    public void modificaQuantVideosVistos()
    {
        this.QuantVideosVistos ++;
    }
    public int ApresentaQuantVideos()
    {
        return this.QuantVideosVistos;
    }
}