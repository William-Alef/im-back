Carro carro1 = new Carro();

carro1.Fabricante = "";
carro1.Modelo = "";
carro1.Ano = 1999;

carro1.acelerar();
carro1.buzinar();
Console.WriteLine("");

Produto produto1 = new Produto();
produto1.Nome = "Teclado Gamer";
produto1.Estoque = 14;
produto1.Preco = 345.90;
produto1.apresentaInformações();

constaBanco conta = new constaBanco();
conta.idConta = 1;
conta.nome = "Joana Maria";
conta.saldo = 5023;
conta.email = "Joana@gmail.com";
conta.senha = "Joana123";

conta.exibirDadosCliente();
