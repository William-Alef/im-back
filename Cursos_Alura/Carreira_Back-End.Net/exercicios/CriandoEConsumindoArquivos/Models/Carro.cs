using CriandoEConsumindoArquivos.Interfaces;
namespace CriandoEConsumindoArquivos.Models;
public class Carro : IVeiculo
{
    public string Marca { get;}
    public string Modelo { get;}
    public string Cor { get;}
    public int Cavalos { get; }
    public decimal Valor { get; set; }
    private int VelocidadeMaxima { get; }
    private bool Ligado { get; set; }
    private bool Acelerando { get; set; }
    private bool Freiando { get; set; }
    private int Velocimetro { get; set;}

    public Carro(string marca, string modelo, string cor, int cavalos, decimal valor, int velocidadeMax) 
    {
        Marca = marca;
        Cor = cor;
        Modelo = modelo;
        Cavalos = cavalos;
        Valor = valor;
        VelocidadeMaxima = velocidadeMax;
    }

    public void Acelerar()
    {
        if(Ligado)
        {
            if (!Acelerando)
            {
                Acelerando = true;
                Console.WriteLine("Acelerando o veículo...");
            }
       
            if(Velocimetro < VelocidadeMaxima)
            {
                Freiando = false;
                Velocimetro += 10;
                Console.WriteLine($"Velocidade atual: {Velocimetro}");
            } 
        }else Console.WriteLine("Não é possivel acelerar com o carro desligado.");
    }

    public void Frear()
    {
        if (!Freiando)
        {
            Freiando = true;
            Console.WriteLine("Freiando o veículo...");
        }

        if (Velocimetro > 0)
        {
            Acelerando = false;
            Velocimetro -= 10;
            Console.WriteLine($"Velocidade atual: {Velocimetro}");
        }
    }

    public void Desligar()
    {
        if (Ligado)
        {
            Console.WriteLine("Desligadndo o veículo...");
            Ligado = false;
        }

        if (Velocimetro > 0)
        {
            while(Velocimetro != 0)
            {
                Velocimetro -= 10;
                Console.WriteLine($"Velocidade atual: {Velocimetro}");
            }
        }
    }

    public void Ligar()
    {
        if (!Ligado)
        {
            Console.WriteLine("Ligando o veículo...");
            Ligado = true;
            Acelerando = false;
        }
    }
}
