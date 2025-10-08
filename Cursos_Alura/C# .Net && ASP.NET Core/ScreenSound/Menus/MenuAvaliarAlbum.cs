using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) 
    {
        base.Executar(bandasRegistradas);
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Qual o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            if (banda.Albuns.Count > 0)
            {
                Console.Write("Qual o nome do album: ");
                string nomeDoAlbum = Console.ReadLine()!;

                if(banda.Albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                    Console.Write($"Qual a sua nota para o album {album.Nome}: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    album.AdicionarNota(nota);
                    ApresentarMensagem(
                        $"\nVocê avaliou o album {nomeDoAlbum} com a nota {nota.Nota}"
                    );
                }
                else
                {
                    ApresentarMensagem(
                        $"\nNo momento, a banda {nomeDaBanda} não possui nenhum album registrado com o nome {nomeDoAlbum}.\n" +
                        $"\nPressione qualquer tecla para voltar ao menu principal"
                    );
                }
            }
            else
            {
                ApresentarMensagem(
                $"\nNo momento a banda {nomeDaBanda} não possui nenhum álbum restrado!" +
                $"\nPressione qualquer tecla para voltar ao menu principal"
                );
            }
        }
        else
        {
            ApresentarMensagem(
                $"\nA banda {nomeDaBanda} não foi encontrada!" +
                $"\nPressione qualquer tecla para voltar ao menu principal"
            );
        }
    }
}
