using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;

//Solicitando e lendo os números.
Console.Write("Entre com o primeiro número: ");
String primeiroNumero = Console.ReadLine()!;
Console.Write("Entre com o segundo número: ");
String segundoNumero = Console.ReadLine()!;

//Convertendo a string de entrada em inteiro.
float a = float.Parse(primeiroNumero);
float b = float.Parse(segundoNumero);

//Realizando as operações.
float adicao = a + b;
float subtracao = a - b;
float divisao = a / b;
float multiplicacao = a * b;
 
//Apresentando o resultado ao usuário.
Console.WriteLine($"\n{a} + {b} = {adicao}\n{a} - {b} = {subtracao}\n{a} / {b} = {divisao}\n{a} * {b} = {multiplicacao}\n");

//Criando uma lista e utilizando foreach para apresentar os itens da lista.
List<string>bandas = new List<string>()
{
    "Iron Maiden",
    "Metallica",
    "Megadeth"
};

foreach (string banda in bandas)
{
    Console.WriteLine(banda);
};

//Criação da lista de números e apresentação para o usuário.
List<int>listaNumerica = new List<int>()
{
    1,
    2,
    5,
    8
};

int somaNumeros = 0;
foreach (int numero in listaNumerica)
{
    somaNumeros += numero;
}
Console.WriteLine($"\nO resultado da soma dos números da lista é {somaNumeros}");