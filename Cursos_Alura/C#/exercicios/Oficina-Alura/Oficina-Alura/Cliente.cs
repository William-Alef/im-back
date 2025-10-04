namespace Oficina_Alura;

internal class Cliente
{
    public  string Nome { get; set; }
    public string Telefone { get; set; }
    public List<Veiculo> Carros { get; set; } = [];
    public Cliente(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }
    public void CadastrarVeiculo(Veiculo veiculo) 
    {
        Carros.Add(veiculo);
    }
}
