using System.Runtime.CompilerServices;
using System.Xml;

public class Video : IAcoesVideo
{
    private string Titulo {get; set;}
    private string Descricao {get;set;} = "";
    private string Avaliacoes {get; set;} = "";
    private int Views {get; set;} = 0;
    private int Curtidas {get; set;} = 0;
    private bool Reproduzindo {get; set;}

    public Video(string titulo, string descricao)
    {
        this.Titulo = titulo;
        this.Descricao = descricao;
    }

    public void ApresentarVideo()
    {
        System.Console.WriteLine($"Vídeo: {Titulo} com {Curtidas} Likes\n{Views} de visualisações.\nDescrição: {Descricao}");
    }
    public void Play()
    {
        if(!Reproduzindo)
        {
            Views++;
            this.Reproduzindo = true;
            System.Console.WriteLine("O vídeo será reproduzido!");
        }
        else
        {
            System.Console.WriteLine("O vídeo já está sendo reproduzido");
        }
    }
    public void Pause()
    {
        if(Reproduzindo)
        {
            this.Reproduzindo = false;
            System.Console.WriteLine("Video pausado");
        }
        else
        {
            System.Console.WriteLine("O vídeo já está pausado!");
        }
    }
    public void Like()
    {
        this.Curtidas++;
        System.Console.WriteLine("O vídeo foi curtido!");
    }
}