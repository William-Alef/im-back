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
            Banda Banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {Banda.Media}.");
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
            ApresentarMensagem("Digite uma tecla para votar ao menu principal");
        }
        else
        {
            ApresentarMensagem($"\nA banda {nomeDaBanda} não foi encontrada!\nDigite uma tecla para voltar ao menu principal");
        }
    }
}

