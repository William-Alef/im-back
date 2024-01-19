using System.Reflection.Emit;

public class ControleRemoto : IControlador
{
    private int Volume{ get; set; }
    private bool Ligado { get; set; }
    private  bool Tocando { get; set; }

    public ControleRemoto()
    {
        this.Volume = 50;
        this.Ligado = false;
        this.Tocando = false;
    }

    public void Ligar()
    {
        this.Ligado = true;
    }

    public void Desligar()
    {   
        this.Ligado = false;
    }

    public void AbrirMenu()
    {
        System.Console.WriteLine($"Está ligado? {Ligado}");
        System.Console.WriteLine($"Está tocando? {Tocando}");
        System.Console.Write($"Volume: {this.Volume}: ");
        for (int i = 0; i <= this.Volume; i++)
        {
            System.Console.Write("|");
        }
    }

    public void FecharMneu()
    {
        System.Console.WriteLine("\nFechando menu!");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void AumentarVolume(int volum)
    {
        if(!this.Ligado)
        {
            System.Console.WriteLine("Não é posível aumentar o volume com a TV desliga!");
        }
        else
        {
            if(this.Volume >= 100)
            {
                System.Console.WriteLine("Volume máximo ativo");
                this.Volume = 100;
            }
            else
            {
                this.Volume += volum;
                Volume = (Volume > 100) ? 100 : Volume;
            }
        }
    }

    public void AbaixarVolume(int volum)
    {
        if(!this.Ligado)
        {
            System.Console.WriteLine("Não é posível abaixar o volume com a TV desliga!");
        }
        else
        {
            this.Volume -= volum;
            Volume = (Volume < 0) ? 0 : Volume;
        }
    }

    public void AtivarMudo()
    {
        if(this.Ligado && this.Volume > 0)
        {
            this.Volume = 0;
        }
        else
        {
            System.Console.WriteLine("Não é possível ativar o volume com a TV desligada ou no mudo");
        }
    }

    public void DesativarMudo()
    {
        if(this.Ligado && this.Volume == 0)
        {
            this.Volume = 50;
        }
    }

    public void Play()
    {
        if(this.Ligado && !this.Tocando)
        {
            this.Tocando = true;
        }
    }

    public void Pause()
    {
        if(this.Ligado && this.Tocando)
        {
            this.Tocando = false;
        }
    }
}
