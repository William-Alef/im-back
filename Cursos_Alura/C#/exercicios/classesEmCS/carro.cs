class Carro
{
    private int ano;
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano { 
        get => ano;
        set{
            if(Ano > 1960 || Ano < 2023){
                ano = value;
            }else{
                Console.Write("Ano inválido!.");
            }
        }
    }
    public int Portas { get; set; }
    public int Velocidade { get; set; }
    public string DescricaoDetalhada =>
        $"Este é um {Modelo} ano {Ano} da {Fabricante}.";

    public void exibirInformacoesCarro()
    {
        Console.Write($"Fabricante: {Fabricante}\nModelo: {Modelo}\nAno: {Ano}\nPortas: {Portas}");
    }
    public void acelerar()
    {
        Console.Write(DescricaoDetalhada);
        if(Velocidade >= 100)
        {
            Console.Write("Já estamos na velocidade máxima!");
        }
        else
        {
            Console.WriteLine("Acelerando!");
            Velocidade += 5;    
        }
    }

    public void frear()
    {
        if(Velocidade <= 0)
        {
            Console.Write("O carro já está parado.");
        }else
        {
            Console.Write("Freando!");
            Velocidade += 5;
        }
    }
    public void buzinar()
    {
        Console.Write("Bip, Bip!");
    }
};

class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }

    public string InformacoesDetalhadas => 
        $"Temos {Estoque} {Nome}`s em estoque no valor de {Preco}";

    private double preco;
    public double Preco 
    { 
        get => preco;
        set{
            if(Preco < 0)
            {
                Console.WriteLine("Valor inválido.");
            }else
            {
                preco = value;
            }
        } 
    }

    private int estoque;
    public int Estoque 
    { 
        get => estoque; 
        set{
            if(Estoque < 0)
            {
                Console.WriteLine("Valor inválido.");
            }else{
                estoque = value;
            }
        } 
    }  
    
    public void apresentaInformações(){
        Console.WriteLine(InformacoesDetalhadas);
    }
};

class constaBanco {

    public int idConta;
    public string nome;
    public string senha;
    public double saldo;
    public string email;

    public void exibirDadosCliente(){
        Console.WriteLine($"Nome do usuário: {nome}");
        System.Console.WriteLine($"O saldo em sistema é: {saldo}");
    }
};