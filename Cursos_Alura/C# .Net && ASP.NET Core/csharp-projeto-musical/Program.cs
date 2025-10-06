using Microsoft.Win32.SafeHandles;
using System.Threading.Channels;

namespace Program
{
    public class Program
    {
        static Dictionary<string, List<double>> bandas = new Dictionary<string, List<double>>();
        static void Main(string[] args)
        {
            int escolha = int.MinValue;
            while (escolha != 0)
            {
                Action acao = Menu();
                acao();
            }
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
            ");
        }

        static void RegistrarBandas()
        {
            Console.Clear();
            Console.Write("Qual o nome da banda: ");
            string NomeBanda = Console.ReadLine()!;

            if (!bandas.ContainsKey(NomeBanda))
            {
                bandas.Add(NomeBanda, new List<double>());
                Console.Write($"A banda {NomeBanda} adicionada com sucesso!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("A banda informada já está na lista!");
                Thread.Sleep(2000);
            }
            Menu();
        }

        static void ListarBandas(Dictionary<string, List<double>> Lista)
        {
            Console.Clear();
            Console.Write("Bandas Registradas: ");
            foreach (var banda in Lista.Keys)
            {
                Console.WriteLine(banda);
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Menu();
        }

        static void AvaliarBanda()
        {
            Console.Clear();
            Console.Write("Entre com o nome da banda: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandas.ContainsKey(nomeBanda))
            {
                Console.Write("Qual a nota: ");
                double nota = double.Parse(Console.ReadLine()!);
                bandas[nomeBanda].Add(nota);
                Console.Write($"A nota {nota} foi registrada com sucesso para a banda {nomeBanda}!");
            }
            else
            {
                Console.WriteLine($"Banda {nomeBanda} não foi localizada");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Menu();
        }

        static void ExibirMediaBanda(Dictionary<string, List<double>> Lista)
        {
            Console.Clear();
            Console.Write("Qual o nome da banda desejada: ");
            string nomeBanda = Console.ReadLine()!;

            if (Lista.ContainsKey(nomeBanda))
            {
                List<double> notasDaBanda = bandas[nomeBanda];
                Console.WriteLine($"\nA média da banda {nomeBanda} é {notasDaBanda.Average():f2}");
            }
            else
            {
                Console.WriteLine($"A banda {nomeBanda} não foi encontrada.");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Menu();

        }

        static Action Menu()
        {
            Console.Clear();
            Logo();
            Console.Write(
                "\nOpções:\n" +
                "1 - Registrar banda\n" +
                "2 - Listar bandas\n" +
                "3 - Avaliar uma banda\n" +
                "4 - Exibir a média de uma banda\n" +
                "0 - Sair\n" +
                "Digite o número: "
            );

            int escolha = int.Parse(Console.ReadLine()!);
            Action acao = escolha switch
            {
                1 => () => RegistrarBandas(),
                2 => () => ListarBandas(bandas),
                3 => () => AvaliarBanda(),
                4 => () => ExibirMediaBanda(bandas),
                0 => () => Environment.Exit(0),
                _ => () => Console.WriteLine("Opção inválida.")
            };
            return acao;
        }
    }
}