using AlbumNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandaNamesPace
{
    public class Banda
    {
        public string Nome { get;}
        public string? Descricao { get; set; }
        private List<Album> Albums { get; set; } = new List<Album>();

        public Banda(string nome, Album album, string? descricao = "Sem descrição")
        {
            Nome = nome;
            Descricao = descricao;
            if (album != null)
            {
                Albums.Add(album);
            }
        }

        public Banda(string nome, string? descricao = "Sem descrição") 
        {
            Nome = nome;
            Descricao = descricao;
        }

        public void AdicionarAlbum(Album Album)
        {
            Albums.Add(Album);
        }

        public void ExibirDiscografia()
        {
            if(Albums != null)
            {
                foreach (var Album in Albums)
                {
                    Console.WriteLine($"Album: {Album.Nome}. Duração total: {(Album.DuracaoTotal/60).ToString("F2").Replace(",", ":")}.");
                }
            }
            else
            {
                Console.WriteLine($"No momento, o album está vazio!");
            }
        }
    }
}
