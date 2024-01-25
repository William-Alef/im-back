using System.ComponentModel;

public abstract class Animal
{
    private float Peso{get; set;}
    private int Idade{get; set;}
    private int QuantidaMembros{get;set;}

    public Animal(float peso, int idade, int quantidaMembros)
    {
        this.Peso = peso;
        this.Idade = idade;
        this.QuantidaMembros = quantidaMembros;
    }
    public abstract void Locomover();
    public abstract void Alimentar();
    public abstract void EmitirSom();
}