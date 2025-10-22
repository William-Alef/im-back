using System.Threading.Channels;
using ScreenSound.Menus;
using ScreenSound.Models;
namespace ScreenSound;
public class Program
{
    static Dictionary<string, Banda> bandasRegistradas = new();
    static void Main(string[] args)
    {
        Dictionary<int, Menu> opcoes = new()
        { 
            {1, new MenuRegistrarBanda()},
            {2, new MeuRegistrarAlbum()},
            {3, new MenuApresentarBandas()},
            {4, new MenuAvaliarBanda()},
            {5, new MenuExibirDetalhes()},
            {0, new MenuSair()},
        };

        Banda LinkinPark = new("Linkin Park");
        Banda Beatles = new("Beatles");
        bandasRegistradas.Add(LinkinPark.Nome, LinkinPark);
        bandasRegistradas.Add(Beatles.Nome, LinkinPark);

        int escolha = int.MinValue;
        do
        {
            ApresentarOpcoesMenu();
            escolha = int.Parse(Console.ReadLine()!);

            Menu menu = opcoes[escolha];

            if (opcoes.ContainsKey(escolha))
            {
                menu.Executar(bandasRegistradas);
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
        while (escolha != 0);
    }

    static void Logo()
    {
        Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
                                    Boas vindas ao Screen Sound 2.0!");
    }

    static void ApresentarOpcoesMenu()
    {
        Logo();
        Console.Write("" +
            "\nDigite 1 para registrar uma banda" +
            "\nDigite 2 para registrar o álbum de uma banda" +
            "\nDigite 3 para mostrar todas as bandas" +
            "\nDigite 4 para avaliar uma banda" +
            "\nDigite 5 para exibir os detalhes de uma banda" +
            "\nDigite 0 para sair\n" +
            "\nDigite o valor desejado: "
        );
    }
}