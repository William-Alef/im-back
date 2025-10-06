namespace Oficina_Alura;

internal class Oficina
{
    public List<Veiculo> VeiculosNaOficina { get; set; } = [];
    public List<Mecanico> Colaboradores { get; set; } = [];

    public Oficina(){}

    public void CadastrarColaborador(Mecanico mecanico)
    {
        Colaboradores.Add(mecanico);
    }
    public void CadastrarVeiculo(Veiculo veiculo)
    {
        VeiculosNaOficina.Add(veiculo);
    }

    public void AdicionarServico(Mecanico mecanico, Veiculo veiculo)
    {
        if(mecanico.AtendendoVeiculo(veiculo))
        {
            Console.WriteLine($"Ó veículo já está sendo atendido pelo colaborador {mecanico}");
        }
        else if(mecanico == null || veiculo == null)
        {
            Console.WriteLine("Mecânico ou veículo inválidos.");
        }
        else
        {
            mecanico.AtenderCarro(veiculo);
        }
    }
    public void FinalizarServico(Mecanico mecanico, Veiculo veiculo)
    {
        mecanico.EntregarServico(veiculo);
    }

    public override string ToString()
    {
        string colaboradoresInfo = String.Join("\n", Colaboradores.Select(c => c.Infos()));
        return $"No momento temos {VeiculosNaOficina.Count} veículos na oficina." +
            $"\n\n{colaboradoresInfo}";
    }
}
