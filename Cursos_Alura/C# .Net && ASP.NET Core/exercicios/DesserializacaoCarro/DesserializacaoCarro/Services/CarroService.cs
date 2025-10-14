using DesserializacaoCarro.Models;
using System.Text.RegularExpressions;
namespace DesserializacaoCarro.Services;
internal class CarroService
{
    public void ApresentarCarros(List<Carro> carros)
    {
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro}\n");
        }
    }

    public void CompararMotor(List<Carro> carros, string Valor1, string Valor2)
    {
        bool valoresValidos = Valor1 != null && Valor2 != null;

        if (carros != null && carros.Count > 0
            && valoresValidos)
        {         
            var primeiroCarro = carros.First(c => c.Marca.Equals(Valor1, StringComparison.OrdinalIgnoreCase));
            var segundoCarro = carros.First(c => c.Marca.Equals(Valor2, StringComparison.OrdinalIgnoreCase));

            if (primeiroCarro != null && segundoCarro != null)
            {
                var primeiroMotorConvertido = ExtrairValorNumericoDoMotor(primeiroCarro.Motor);
                var segundoMotorConvertido = ExtrairValorNumericoDoMotor(segundoCarro.Motor);
                if (primeiroMotorConvertido  > segundoMotorConvertido)
                {
                    Console.WriteLine($"O motor do {primeiroCarro.Marca} {primeiroCarro.Modelo} é mais potente que o motor do {segundoCarro.Marca} {segundoCarro.Modelo}!");
                }
                else if(segundoMotorConvertido > primeiroMotorConvertido)
                {
                    Console.WriteLine($"O motor do {segundoCarro.Marca} {segundoCarro.Modelo} é mais potente que o motor do {primeiroCarro.Marca} {primeiroCarro.Modelo}!");
                }
            }
            else
            {
                Console.WriteLine("Um ou mais valores informados não correspondem com os veículos registrados em sistema.");
            }
        }
        else 
        {
            Console.WriteLine("Um ou mais valores informados não são válidos.");
        }
    }

    public void FiltrarPorTipo(List<Carro> carros, string Valor)
    {
        if (carros?.Any() == true && Valor != null)
        {
            var carrosFiltrados = carros.Where(c => c.Marca.Equals(Valor, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (carrosFiltrados.Count > 0)
            {
                foreach (var carro in carrosFiltrados)
                {
                    Console.WriteLine(carro);
                }
            }
            else Console.WriteLine($"Nenhum carro da marca {Valor} foi encontrado.");
        }
        else Console.WriteLine("Um ou mais valores informados são inválidos por serem nulos.");
    }

    private double ExtrairValorNumericoDoMotor(string motorString)
    {
        if (string.IsNullOrWhiteSpace(motorString))
        {
            return 0;
        }

        var match = Regex.Match(motorString, @"(\d+[\.\,]?\d*)");
        if (match.Success)
        {
            string valorNumerico = match.Value;

            if (double.TryParse(valorNumerico.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double resultado))
            {
                return resultado;
            }
        }
        return 0;
    }
}
