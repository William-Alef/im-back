using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MeuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.Write("Digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;

        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        ApresentarMensagem(
            $"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!" +
            $"Pressione qualquer tecla para voltar ao menu."
        );
    }
}
