using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuApresentarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        ApresentarMensagem("\nDigite uma tecla para voltar ao menu principal");
    }
}
