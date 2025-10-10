using DadosDePassageiros.Models;

namespace DadosDePassageiros;

public class Program
{
    static void Main(string[] args)
    {
        Passageiro p1 = new Passageiro("Lúcia", 45, 3);
        Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

        p1.ApresentarDados();
        p2.ApresentarDados();

        /*
        Imagine que você está desenvolvendo um sistema para uma empresa de transporte que precisa gerenciar informações sobre seus passageiros. Cada pessoa cadastrada possui dados básicos, como nome e idade, mas os passageiros também podem informar quantos bilhetes já adquiriram. Seu objetivo é criar uma estrutura que organize essas informações de forma clara e eficiente.

        Crie um programa que:

        Defina uma classe Pessoa com os atributos Nome e Idade.
        Crie a classe Passageiro, herdando de Pessoa, e adicione o atributo QuantidadeBilhetes.
        Implemente um método dentro de Passageiro para exibir os dados formatados no console.
        Cadastre dois passageiros com dados fictícios e exiba suas informações.
        */
    }
}