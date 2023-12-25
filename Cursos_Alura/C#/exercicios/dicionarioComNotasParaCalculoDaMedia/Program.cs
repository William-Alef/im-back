﻿using System.ComponentModel.Design;
using System.Data;
using System.Reflection.Metadata;
Dictionary<string, List<String>> logins = new Dictionary<string, List<string>>();
Dictionary<string, List<double>> notas = new Dictionary<string, List<double>>();

opcoesMenu();

void opcoesMenu()
{
    Console.Write("Bem vindo!\n\nDigite o número da ação desejada: \n(1) Para registrar alunos e suas notas.\n(2) Gerenciamento do estoque de uma loja.\n(3) Jogar Quiz.\n(4) Sistema de login.\n\nEscolha: ");
    int escolhaMenu = int.Parse(Console.ReadLine()!);

    switch (escolhaMenu)
    {
        case 1: gerenciamentoDeNotas();
        break;

        case 2: //gerenciamentoDeEstoque();
        break;

        case 3: //jogarQuiz();
        break;
        
        case 4: sistemaDeLogin();
        break;

        default: Console.WriteLine("\n\nOpção não aceita\nPor favor, Selecione uma opção válida."); Thread.Sleep(2000); opcoesMenu();
        break;
    }
};

void gerenciamentoDeNotas()
{
    Console.Write("\nQual a quantidade de alunos: ");
    int quantidadeAlunos = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < quantidadeAlunos; i++)
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine()!;
        if(notas.ContainsKey(nome))
        {
            Console.Write($"O aluno {nome} já consta em sistema, gostaria de adicionar uma nova nota para o mesmo?\nDigite:\n\n(1) para Sim\n(2) para Não\nEscolha: ");
            int incluirNota = int.Parse(Console.ReadLine()!);
            
            if(incluirNota == 1)
            {
                Console.Write("Quantas notas deseja atribuir ao aluno: ");
                int quantidadeNotas = int.Parse(Console.ReadLine()!);

                for (int contador = 0; contador < quantidadeNotas; contador++)
                {
                    Console.Write($"Qual a nota do aluno {nome}: ");
                    double novaNota = double.Parse(Console.ReadLine()!);
                    notas[nome].Add(novaNota);
                }

                Console.Write("Deseja calcular a média dos alunos: \n(1) Para sim\n(2) Para não\nEscolha: ");
                int calcularMedia = int.Parse(Console.ReadLine()!);

                if(calcularMedia == 1)
                {
                    foreach (var aluno in notas)
                    {
                        List<double> notasAluno = aluno.Value;
                        double media = notasAluno.Count > 0 ? notasAluno.Average() : 0;
                        Console.WriteLine($"\n{nome} com média {media}");
                    }
                }
            }
        }else
        {  
            Console.Write($"Qual a nota do aluno {nome}: ");
            double nota = double.Parse(Console.ReadLine()!);
            notas.Add(nome, new List<double> {nota});
        }
    }
    Console.WriteLine("Alunos adicionados: ");
    foreach (var aluno in notas)
    {
        Console.WriteLine($"\n{aluno.Key} com as notas: {string.Join(", ", aluno.Value)}");
    }  
    Console.WriteLine("Voltando ao menu inicial.");
    Thread.Sleep(2000);
    opcoesMenu();
}



void sistemaDeLogin(){
    Console.Write("Bem vindo ao sistema de login!\nDigite o número da opção desejada.\n(1) Criar login e senha.\n(2) Entrar com login e senha.\n(3) Voltar ao menu. \nEscolha: ");
    int escolhaLogin = int.Parse(Console.ReadLine()!);
    switch (escolhaLogin)
    {
        case 1: criarLogin();
        break;

        case 2: entrarComLogin();
        break;

        case 3: Console.WriteLine("Voltando ao menu inicial."); opcoesMenu();
        break;

        default: Console.WriteLine("Por favor, entre com um valor "); sistemaDeLogin();
        break;
    }

    void criarLogin(){
        Console.Write("Login: ");
        string usuario = Console.ReadLine()!;

        Console.Write("Senha: ");
        string senha = Console.ReadLine()!;
        
        string confirmaSenha = "";
        int contador = 0;
        do
        {
            if (contador > 1)
            {
                Console.WriteLine("\nSenha de confirmação errada!");
            }
            Console.Write("Confirme a senha: ");
            confirmaSenha = Console.ReadLine()!;   
            contador++;

        }while(senha != confirmaSenha);

        logins.Add(usuario, new List<string> {senha});

    }
    void entrarComLogin(){

    };
}