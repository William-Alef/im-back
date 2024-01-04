class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int portas;
    public int velocidade;

    public void exibirInformacoesCarro()
    {
        Console.Write($"Fabricante: {fabricante}\nModelo: {modelo}\nAno: {ano}\nPortas: {portas}");
    }
    public void acelerar()
    {
        if(velocidade >= 100)
        {
            Console.Write("Já estamos na velocidade máxima!");
        }
        else
        {
            Console.WriteLine("Acelerando!");
            velocidade += 5;    
        }
    }

    public void frear()
    {
        if(velocidade <= 0)
        {
            Console.Write("O carro já está parado.");
        }else
        {
            Console.Write("Freando!");
            velocidade += 5;
        }
    }
    public void buzinar()
    {
        Console.Write("Bip, Bip!");
    }
};
