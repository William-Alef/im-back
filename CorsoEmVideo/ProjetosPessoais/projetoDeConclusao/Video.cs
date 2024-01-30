using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Video : IAcoesVideo
{
    private string Titulo {get; set;}
    private string Descricao {get;set;} = "";
    private int Avaliacao {get; set;}
    private int Views {get; set;}
    private int Curtidas {get; set;}
    private bool Reproduzindo {get; set;}
    private int Tot{get; set;}

    public Video(string titulo, string descricao)
    {
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Avaliacao = 1;
        this.Views = 0;
        this.Curtidas = 0;
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
    public void AdicionaView()
    {
        this.Views +=1;
    }
    
    public void Avaliar()
    {
        this.Avaliacao += 5;
    }
    public void Avaliar(int nota)
    {
        this.Avaliacao += nota;
    }
    public void Avaliar(float porc)
    {
        
        if(porc <= 20)
        {
            Tot = 3;
        }
        if(porc <= 50)
        {
            Tot = 5;
        }
        if(porc <= 90)
        {
            Tot = 8;
        }
        else
        {
            Tot = 10;
        }
    }

    public string NomeVideo()
    {
        return this.Titulo;
    }
    public int ApresentarView()
    {
        return this.Views;
    }
}