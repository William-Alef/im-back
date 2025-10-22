using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MeuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite o nome da banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            do
            {
                string nomeDoAlbum;
                Console.Write("Qual o nome do Album: ");
                nomeDoAlbum = Console.ReadLine()!;
                if (banda.Albuns.Any(e => e.Nome.Equals(nomeDoAlbum)))
                {
                    Console.Write($"\nIdentificamos que a banda {nomeDaBanda} já possui um album registrado com o nome {nomeDoAlbum}.\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                else
                {
                    Album album = new Album(nomeDoAlbum);
                    banda.AdicionarAlbum(album);
                    ApresentarMensagem($"O álbum {nomeDoAlbum} foi adicionado com sucesso!");
                    break;
                }
            }
            while (true);
        }
        else
        {
            ApresentarMensagem($"Não localizamos a banda {nomeDaBanda}." +
                $"\nPressione qualquer tecla para voltar ao menu."
            );
        }
    }
}
