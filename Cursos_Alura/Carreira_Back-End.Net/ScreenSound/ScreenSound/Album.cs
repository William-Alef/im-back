using MusicaNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumNamespace
{
    public class Album
    {
        public Musica Musica { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        private List<Musica> MusicasAlbum { get; set; }
        public double DuracaoTotal => MusicasAlbum.Sum(mus => mus?.Duracao ?? 0.0);

        public Album(string nome, Musica musica, string description) 
        {
            Nome = nome;
            Musica = musica;
            Descricao = description;
            MusicasAlbum = [musica];
             
        }
        public void AdicionarMusica(Musica musica)
        {
            MusicasAlbum.Add(musica);
        }
        public void InformaçõeAlbum()
        {
            Console.WriteLine(
                $"Album: {Nome}\n" +
                $"Descrição: {Descricao}\n" +
                $"Quantidade de músicas: {MusicasAlbum.Count}\n" +
                $"Duração total: {(DuracaoTotal/60).ToString("F2").Replace(",", ":")}."
            );
        }

        public void ExibirMusicas()
        {
            Console.WriteLine("Lista de músicas:");
            foreach (var musica in MusicasAlbum)
            {
                Console.WriteLine(string.Join(", ", musica));
            }
        }
    }
}
