namespace Oficina_Alura;
internal class Mecanico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }
    List<Veiculo> CarrosAtendidos { get; set; } = [];

    public Mecanico(string nome, string especialidade) 
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public void AtenderCarro(Veiculo veicuo)
    {
        CarrosAtendidos.Add(veicuo);
    }

    public void EntregarServico(Veiculo veiculo)
    {
        CarrosAtendidos.Remove(veiculo);
    }
    public bool AtendendoVeiculo(Veiculo veiculo)
    {
        return CarrosAtendidos.Contains(veiculo);
    }
    public string Infos()
    {
        string veiculos = CarrosAtendidos.Count > 0 ?
            string.Join(", ", CarrosAtendidos.Select(v => v.Modelo)) 
            : "Nenhum veículo atendido no momento.";
        return $"{Nome}: {veiculos}"; 
    }
}
