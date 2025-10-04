using Oficina_Alura.Models;

namespace AluraOficina;
public class Program
{
    static void Main(string[] args)
    {
        Oficina oficina = new();
        Mecanico joao = new("João", "Mecânica Geral");
        Mecanico maria = new("Maria", "Elétrica");
        Mecanico pedro = new("Pedro", "Freios");

        oficina.CadastrarColaborador(joao);
        oficina.CadastrarColaborador(maria);
        oficina.CadastrarColaborador(pedro);

        Cliente cliente1 = new("Carlos Garcia", "(11)99999-9999");
        Cliente cliente2 = new("Gabriel Motta", "(11)99999-9999");
        Cliente cliente3 = new("Mariana Saal", "(11)99999-9999");

        Veiculo carro1 = new("ABC-1234", "Honda", "Civic", new DateTime(2020), cliente1);
        Veiculo carro2 = new("DEF-5678", "Fiat", "Palio", new DateTime(2021), cliente2);
        Veiculo carro3 = new("DEF-5678", "Fiat", "Palio", new DateTime(2021), cliente3);
        Veiculo carro4 = new("DEF-5678", "Honda", "HB20", new DateTime(2022), cliente3);

        oficina.CadastrarVeiculo(carro1);
        oficina.CadastrarVeiculo(carro2);
        oficina.CadastrarVeiculo(carro3);
        oficina.CadastrarVeiculo(carro4);

        oficina.AdicionarServico(joao, carro1);
        oficina.AdicionarServico(maria, carro2);
        oficina.AdicionarServico(maria, carro4);
        oficina.AdicionarServico(pedro, carro3);

        Console.WriteLine(oficina);
    }
}