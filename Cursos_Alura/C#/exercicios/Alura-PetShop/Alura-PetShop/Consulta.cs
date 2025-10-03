namespace Alura_PetShop;

internal class Consulta
{
    public DateTime Data { get; set; }
    public Dono Dono { get; set; }
    public Pet Pet { get; set; }
    public Medico Medico { get; set; }
    public string Descricao { get; set; }

    public Consulta(DateTime data, Dono dono, Pet pet, Medico medico, string descricao) 
    {
        Data = data;
        Dono = dono;
        Pet = pet;
        Medico = medico;
        Descricao = descricao;
        pet.AgendaConsultas(this);
    }
    public override string ToString()
    {
        return $"Consulta agenda para o dia {Data:dd/MM/yyyy}"+
            $"\nPaciente: {Pet.Nome}" +
            $"\nDono: {Dono.Nome}" +
            $"\nMédico: {Medico.Nome}\n" +
            $"\nDescrição:" +
            $"\n{Descricao}";
    }
}
