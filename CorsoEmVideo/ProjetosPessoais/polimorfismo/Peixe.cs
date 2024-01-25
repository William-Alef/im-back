public class Peixe : Reptil
{
    public Peixe(float peso, int idade, int quantidaMembros, string corDaEscama) : base(peso, idade, quantidaMembros, corDaEscama)
    {

    }
    public void SoltarBolha()
    {
        System.Console.WriteLine("Soltando bolha!");
    }
    public override void Alimentar()
    {
        System.Console.WriteLine("Comendo vegetais");
    }

    public override void EmitirSom()
    {
        System.Console.WriteLine("Emitindo som na frequência de peixe!");
    }

    public override void Locomover()
    {
        System.Console.WriteLine("Nadando!");
    }
}