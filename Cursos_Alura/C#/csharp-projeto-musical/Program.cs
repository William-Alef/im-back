﻿// Screen Sound
using System.Data.Common;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

List<string>bandas = new List<string>()
{

};

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

void registrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas\n");
    Console.Write("Informe o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A Banda {nomeDaBanda} foi registrada com sucesso!");
    bandas.Add(nomeDaBanda);
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibirBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Bandas registradas");

    foreach (string banda in bandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    
    Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial.");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda banda");
    Console.WriteLine("Digite 5 para sair");
}

Console.Write("\nQual a opção desejada: ");
string escolha = Console.ReadLine()!;
int opcaoEscolhidaNumerica = int.Parse(escolha);

switch(opcaoEscolhidaNumerica)
{
    case 1: registrarBandas();
    break;
    case 2: exibirBandasRegistradas();
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