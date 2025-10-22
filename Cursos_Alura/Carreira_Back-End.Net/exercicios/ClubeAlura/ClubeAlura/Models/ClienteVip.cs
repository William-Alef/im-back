namespace ClubeAlura.Models;
internal class ClienteVip : Pessoa
{
    public string NivelFidelidade { get; set; }
    public string CodigoVip { get; set; }

    public ClienteVip(string nome, int idade, string nivelFididelidade, string codigoVip) : base(nome, idade)
    { 
        NivelFidelidade = nivelFididelidade;
        CodigoVip = codigoVip;    
    }

    public override string ToString()
    {
        return $"Bem vindo, cliente VIP: {Nome}!" +
            $"\nIdade: {Idade}" +
            $"\nNível de Fidelidae: {NivelFidelidade}" +
            $"\nCódigo VIP: {CodigoVip}";
    }
}