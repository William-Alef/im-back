using GerenciadorDeMusicas.Models.Comparers;
using System.Collections;

namespace GerenciadorDeMusicas.Models
{
    internal class PlaylistModel : ICollection<MusicaModel>
    {
        public string Nome { get;}
        public string Descricao { get; set; }
        private HashSet<MusicaModel> _listaUnica { get; set; } = [];
        private List<MusicaModel> _musicas { get; set; } = [];

        public int Count => _musicas.Count;

        public bool IsReadOnly => false;

        public PlaylistModel(string Nome, string Descricao, MusicaModel? musica = null)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            if (musica != null) Add(musica);
        }

        public void TocarMusicaAleatoria()
        {
            if (_musicas.Count == 0)
            {
                Console.WriteLine("Impossível reproduzir uma música, pois a lista está vazia.");
            }
            else
            { 
                Random PseudoRandomico = new();
                int index = PseudoRandomico.Next(0, _musicas.Count - 1);
                Console.WriteLine($"Tocando a música {_musicas[index].Nome}");
            }
        }

        public void Add(MusicaModel musica)
        {
            if (musica != null)
            {
                if (_listaUnica.Add(musica)) 
                { 
                    _musicas.Add(musica);
                    Console.WriteLine($"\nMúsica {musica.Nome} adicionada com sucesso na playlist {Nome}");
                }
            }
            else Console.WriteLine("\nA música fornecida é nula.");
        }

        public bool Remove(MusicaModel musica)
        {
            if (Contains(musica))
            {
                _musicas.Remove(musica);
                Console.WriteLine($"\nA música {musica.Nome} foi removida com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("\nA música não foi encontrada."); 
                return false;
            }
        }

        public void Clear()
        {
            _musicas.Clear();
        }

        public bool Contains(MusicaModel musica)
        {
            if (musica is null) return false;
            return _musicas.Contains(musica);

        }

        public void CopyTo(MusicaModel[] lista, int index)
        {
            _musicas.CopyTo(lista, index);
        }


        public IEnumerator<MusicaModel> GetEnumerator()
        {
            return _musicas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void OrdenarPorDuracao()
        {
            _musicas.Sort((x, y) => x.Duracao.CompareTo(y.Duracao));
        }
        public void OrdenarPorArtista()
        {
            _musicas.Sort(new MusicaPorArtistaComparer());
        }

        public void OrdenarPorNome()
        {
            _musicas.Sort(new MusicaPorNomeComparer());
        }

        public override string ToString()
        {
            string ListaDeMusicas = _musicas.Count > 0
                ? string.Join(", ", _musicas.Select(m => m.Nome))
                : "No momento, a playlist não possui músicas registradas.";
            return
                $"Nome: {Nome}\n" +
                $"Descrição: {Descricao}\n" +
                $"Músicas registradas: {Count}\n" +
                $"Discografia: {ListaDeMusicas}";
        }

    }
}
