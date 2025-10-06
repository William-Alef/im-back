namespace Alura_PetShop.Models;

internal class Medico
{
    public string Nome{ get; set; }
    public string Especialidade{ get; set; }
    List<Consulta> Consultas { get; set; } = [];

    public Medico(string nome, string especialidade) 
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public void AdicionarConsultas(Consulta consulta)
    {
        Consultas.Add(consulta);
    }
    public void RemoverConsulta(Consulta Consulta)
    {
        Consultas.Remove(Consulta);
    }
}
