class Canguru : Mamifero
{
    public Canguru(float peso, int idade, int quantidaMembros, string CorDaPele) : base(peso, idade, quantidaMembros, CorDaPele)
    {
        
    }

    public void UsarBolsa()
    {
        System.Console.WriteLine("Guardando sua cria na bolsa");
    }
    public override void Locomover()
    {
        System.Console.WriteLine("Pulando");
    }
}