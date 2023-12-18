// Screen Sound
using System.Data.Common;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";


void exibirBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);

}

void exibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda banda");
    Console.WriteLine("Digite 5 para sair");
}

Console.WriteLine("\nQual a opção desejada: ");
string escolha = Console.ReadLine()!;
int opcaoEscolhidaNumerica = int.Parse(escolha);

switch(opcaoEscolhidaNumerica)
{
    case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
    break;
    case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
    break;
    case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
    break;
    case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
    break;
    case 5: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
    break;
    default: Console.WriteLine("Desculpe, mas nenhuma destas opções é válida!");
    break;
}

exibirBoasVindas();
exibirOpcoesDoMenu();


/*
var nomes = new List<string>()
{
    "Maria",
    "Jose",

};

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}
*/