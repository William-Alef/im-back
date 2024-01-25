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
}