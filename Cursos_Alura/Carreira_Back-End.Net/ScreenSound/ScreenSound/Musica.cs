using BandaNamesPace;
using GeneroNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MusicaNamespace
{
    public class Musica(string nome, double duracao, Banda artista, Genero genero)
    {
        public string Nome { get; } = nome;
        public Banda Artista { get; } = artista;
        public double Duracao { get; set; } = duracao;
        public Genero Genero { get; set; } = genero;
        private bool _disponivel { get;} = false;

        public void ExibirFichaTecnica(Musica musica)
        {
            Console.WriteLine(
                $"Nome: {Nome}" +
                $"\nDuração: {(Duracao/60).ToString("F2").Replace(",", ":")}" +
                $"\n Gênero: {Genero.Nome}" +
                $"\nArtista: {Artista.Nome}\n"
            );
            if (!_disponivel)
            {
                Console.WriteLine(
                   "Música indisponível no plano atual. " +
                   " Adiquira o plano++ para obter acesso."
                );
            }
            else
            {
                Console.WriteLine("Música disponível no plano atual!");
            }    
        }

        public override string ToString()
        {
            return $"Música: "
                + Nome
                + ". Gênero: " 
                + Genero.Nome
                + ". Banda: "
                + Artista
                + ". possui "
                + (Duracao/60).ToString("F2").Replace(",", ":")
                +" de duração.";
        }
    }
}
