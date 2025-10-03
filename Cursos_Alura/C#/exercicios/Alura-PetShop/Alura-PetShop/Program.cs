namespace Alura_PetShop;
public class MyClass
{
    static void Main(string[] args)
    {
        Dono joao = new Dono("João", 35);
        Dono maria = new Dono("Maria", 28);

        Pet raze = new Pet("Raze", 5, "Pastor Alemão", joao);
        Pet yoru = new Pet("Yoru", 10, "Labrador", joao);
        Pet viper = new Pet("Viper", 2, "Bulldog", joao);
        Pet brim = new Pet("Brim", 4, "Poodle", maria);
        Pet wayLay = new Pet("Waylay", 1, "Beagle", maria);

        joao.RegistrarPet(raze);
        joao.RegistrarPet(yoru);
        joao.RegistrarPet(viper);
        maria.RegistrarPet(brim);
        maria.RegistrarPet(wayLay);

        Medico drCarlos = new Medico("Carlos", "Clínico Geral");
        Medico draAna = new Medico("Ana", "Dermatologista Veterinária");

        Consulta consulta1 = new Consulta(new DateTime(2025, 10, 10), joao, raze, drCarlos, "Exame de rotina");
        Consulta consulta2 = new Consulta(new DateTime(2025, 10, 15), maria, yoru, draAna, "Exame detalhado de ocorrência de alterações na pelagem e pele do animal");

        drCarlos.AdicionarConsultas(consulta1);
        draAna.AdicionarConsultas(consulta2);

        Console.WriteLine(consulta1);
    }
}