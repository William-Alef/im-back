using EpisodioNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastNamespace
{
    public class Podcast
    {
        public string Nome{ get;}
        List<string> Host { get; set; }
        private List<Episodio> EpisodiosPodcast { get; set; }
        public int TotalEpisodios => EpisodiosPodcast.Count();
        
        public Podcast(string host, string nome)
        {
            Host = [];
            Host.Add(host);
            Nome = nome;
            EpisodiosPodcast = [];  
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            EpisodiosPodcast.Add(episodio);
        }

        public void ExibirDetalhes ()
        {
            Console.WriteLine(
                $"O Podcast {Nome} é guiado pelo Host {string.Join(", ", Host)} e conta com {TotalEpisodios} episódios.\n"
            );

            foreach (var ep in EpisodiosPodcast.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"Ep.{ep.Ordem} {ep.Titulo} {(ep.Duracao/60).ToString("F2").Replace(",", ":")} de duração. Convidados: {string.Join(", ", ep.Convidados)}");
            }
        }
    }
}
