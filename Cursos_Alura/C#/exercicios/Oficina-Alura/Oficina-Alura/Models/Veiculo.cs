using Microsoft.VisualBasic;

namespace Oficina_Alura.Models
{
    internal class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public Cliente Dono { get; set; }
        
        public Veiculo(string placa, string marca, string modelo, DateTime ano, Cliente dono) 
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Dono = dono;
        }
    }
}
