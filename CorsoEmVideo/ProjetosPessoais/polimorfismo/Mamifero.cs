public class Mamifero : Animal
{
    private string CorDaPele{get;set;}

    public Mamifero(float peso, int idade, int quantidaMembros, string CorDaPele) : base(peso, idade, quantidaMembros)
    {
        this.CorDaPele = CorDaPele;
    }
    public override void Alimentar()
    {
        System.Console.WriteLine("Mamando");
    }

    public override void EmitirSom()
    {
        System.Console.WriteLine("Emitindo som de mamifero!");
    }

    public override void Locomover()
    {
        System.Console.WriteLine("Correndo");
    }
}