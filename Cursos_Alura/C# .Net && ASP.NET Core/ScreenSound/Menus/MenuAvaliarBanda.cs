using ScreenSound.Models;
using ScreenSound.Menus;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda Banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            Banda.AdicionarNota(nota);
            ApresentarMensagem($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
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

