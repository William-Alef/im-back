
namespace Alura_PetShop;

internal class Dono
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Pet> Pets { get; set; } = [];
    public Dono(string nome, int idade) 
    {
        Nome = nome;
        Idade = idade;
    }

    public void RegistrarPet(Pet pet)
    {
        Pets.Add(pet);
        pet.RelacionamentoDono(this);
    }
}
