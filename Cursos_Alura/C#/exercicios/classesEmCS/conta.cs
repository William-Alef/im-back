using System.Net.Mail;
using System.Runtime.CompilerServices;

class constaBanco {

    public int idConta;
    public string nome;
    public string senha;
    public double saldo;
    public string email;

    public void exibirDadosCliente(){
        Console.WriteLine($"Nome do usuário: {nome}");
        System.Console.WriteLine($"O saldo em sistema é: {saldo}");
    }
};