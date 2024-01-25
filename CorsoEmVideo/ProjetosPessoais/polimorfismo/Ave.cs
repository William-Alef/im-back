public class Ave : Animal
{
    private string CorDaPena{get;set;}
    public Ave(float peso, int idade, int quantidaMembros, string corDaPena) : base(peso, idade, quantidaMembros)
    {
        this.CorDaPena = corDaPena;
    }

    public override void Alimentar()
    {
        System.Console.WriteLine("Comendo frutas, cementes ou insetos");
    }

    public override void EmitirSom()
    {
        System.Console.WriteLine("Emitindo som de ave!");
    }

    public override void Locomover()
    {
        System.Console.WriteLine("Voando!");
    }
    public void FazerNinho()
    {
        System.Console.WriteLine("Criando um ninho com galhos");
    }
}