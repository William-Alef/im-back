using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public MenuExibirDetalhes()
    {
    }
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            if (banda.Albuns.Count > 0)
            {
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
                Console.WriteLine($"\nMédia detalhada dos álbuns da banda {banda.Nome}");

                foreach (var album in banda.Albuns)
                {
                    Console.WriteLine($"{album.Nome}: {album.Media}");
                }
                ApresentarMensagem("Digite uma tecla para votar ao menu principal");
            }
            else
            {
                ApresentarMensagem($"Identificamos que a banda {banda.Nome} não possui álbuns regustrados.");
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

