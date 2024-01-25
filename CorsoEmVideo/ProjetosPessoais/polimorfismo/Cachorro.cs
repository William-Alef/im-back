using System.Data.SqlTypes;

public class Cachorro : Mamifero
{
    public Cachorro(float peso, int idade, int quantidaMembros, string CorDaPele) : base(peso, idade, quantidaMembros, CorDaPele)
    {
    }
    public void EsconderOsso()
    {
        System.Console.WriteLine("Cavando e escondendo o osso");
    }
    public void AbanarRabo()
    {
        System.Console.WriteLine("Abanando o rabo");
    }
    public override void EmitirSom()
    {
        System.Console.WriteLine("Au Au!");
    }
    public void reacao(String tomDeVoz)
    {
        if(tomDeVoz.ToUpper() == "AGRADAVEL")
        {
            System.Console.WriteLine("Abanando o rabo e latindo pela fala em tom agradável");
        }
        if(tomDeVoz.ToUpper() == "AGRESSIVO")
        {
            System.Console.WriteLine("Latindo e rosnando pela fala em um tom agressivo");
        }
    }
    public void reacao(int hora)
    {
        if(hora <= 12)
        {
            System.Console.WriteLine("Abanando o rabo olhando para o dono");
        }
        if(hora >= 18)
        {
            System.Console.WriteLine("Ignorando o dono");
        }
        else
        {
        
           System.Console.WriteLine("Abanando o rabo e latindo olhando apra o dono"); 
        }
    }
    public void reacao(bool dono)
    {
        if(dono)
        {
            System.Console.WriteLine("Abanando o rabo olhando para o dono");
        }
        else
        {
            System.Console.WriteLine("Cachorro rosnando e latindo para o estranho");
        }
    }
    public void reacao(int idade, float peso)
    {
        if(idade <= 5)
        {
            if(peso < 10)
            {
                System.Console.WriteLine("Um pequeno cachorro abanando o rabo");
            }
            else
            {
                System.Console.WriteLine("Um pequeno cachorro latindo");
            }
        }
        else
        {
            if(peso < 10)
            {
                System.Console.WriteLine("Um cachorro mais velho e leve rosnando");
            }
            else
            {
                System.Console.WriteLine("Um cachorro mais leve e pesado apenas ignorando a presença humana");
            }
        }
    }
}