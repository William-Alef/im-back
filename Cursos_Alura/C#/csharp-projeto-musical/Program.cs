// Screen Sound
using System.Data.Common;
using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

//List<string>bandas = new List<string>()
{

};
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();


exibirBoasVindas();
Thread.Sleep(1000);
exibirOpcoesDoMenu();

void exibirBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void exibirOpcoesDoMenu()
{
    exibirTitulo("Opções do menu\n");
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nQual a opção desejada: ");
    string escolha = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(escolha);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: registrarBandas();
        break;
        case 2: exibirBandasRegistradas();
        break;
        case 3: avaliarBanda();
        break;
        case 4: exibirMediaDasBandas();
        break;
        case 5: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
        default: Console.WriteLine("Desculpe, mas nenhuma destas opções é válida!");
        break;
    }

}

void registrarBandas()
{
    Console.Clear();
    exibirTitulo("Registro de bandas\n");
    Console.Write("Informe o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A Banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibirBandasRegistradas()
{
    Console.Clear();
    exibirTitulo("Bandas registradas\n");

    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    
    Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial.");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string caracteres = "".PadLeft(quantidadeDeLetras, '=');

    Console.WriteLine(caracteres);
    Console.Write(titulo);
    Console.WriteLine(caracteres);
};

void avaliarBanda()
{
    Console.Clear();
    exibirTitulo("Avaliar banda\n");
    Console.Write("Qual o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;

    if(bandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Thread.Sleep(1100);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}!");
        Thread.Sleep(3000);
        Console.Clear();
        exibirOpcoesDoMenu();
    }else
    {
        Console.Write("Desculpe, mas a banda informada não foi localizada em sistema.\nAperte qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
        exibirOpcoesDoMenu();
    };
};

void exibirMediaDasBandas()
{
    Console.Clear();
    exibirTitulo("Media da banda\n");
    Console.Write("Por gentileza, qual o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    
    if(bandas.ContainsKey(nomeBanda))
    {
        double mediaBanda = bandas[nomeBanda].Average();
        Console.WriteLine($"A média de notas para a banda {nomeBanda} é {mediaBanda}!\nVoltando ao menu inicial."); Thread.Sleep(3000);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial."); Console.ReadKey(); Console.Clear(); exibirOpcoesDoMenu();
    }else
    {
        Console.WriteLine("Desculpe, mas não identificamos a banda informada em nosso sistema.\nPressione qualquer tecla para voltar ao menu inicial."); Console.ReadKey(); Console.Clear(); exibirOpcoesDoMenu();
    };
};

exibirBoasVindas();
exibirOpcoesDoMenu();

