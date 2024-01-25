public class Reptil : Animal
{   
    private string CorDaEscama{get;set;}
    public Reptil(float peso, int idade, int quantidaMembros, string corDaEscama) : base(peso, idade, quantidaMembros)
    {
        this.CorDaEscama = corDaEscama;
    }

    public override void Alimentar()
    {
        System.Console.WriteLine("Comendo vegetais");
    }

    public override void EmitirSom()
    {
        System.Console.WriteLine("Emitindo som de réptil!");
    }

    public override void Locomover()
    {
        System.Console.WriteLine("Rastejando!");
    }
}