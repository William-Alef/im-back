
using System.Threading.Channels;
namespace Alura_PetShop;

internal class Pet
{
    public string Nome{ get; set; }
    public int Idade{ get; set; }
    public string Especie { get; set; }
    public Dono Dono{ get; set; }
    public List<Consulta> Consultas { get; set; } = [];
    
    public Pet(string nome, int idade, string especie, Dono dono)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
        Dono = dono;
    }
    
    public void RelacionamentoDono(Dono dono)
    {
        Dono = dono;
    }
    public void AgendaConsultas(Consulta Consulta)
    {
        Consultas.Add(Consulta);
    }

    public void RemoverConsulta(Consulta Consulta)
    {
        Consultas.Remove(Consulta);
    }

    public void ConsultasAgendada()
    {
        if (Consultas.Any()) 
            Consultas.ForEach(Console.WriteLine);
        else
            Console.WriteLine($"No momento, o {Nome} não possui nenhuma consulta");
    }
}

