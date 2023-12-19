using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;

//Solicitando e lendo os números e o operador.
Console.Write("Entre com o primeiro número: ");
String a = Console.ReadLine()!;
Console.Write("Entre com o segundo número: ");
String b = Console.ReadLine()!;
Console.Write("\nOperadores:\n(+) Adição\n(-) Subtração\n(/) Divisão\n(*) Multiplicação\n\nEntre com o simbolo para a operação desejada: ");
String operador = Console.ReadLine()!;

//Convertendo a string de entrada em inteiro.
double primeiroNumero = float.Parse(a);
double segundoNumero = float.Parse(b);

//Realizando a operação matemática baseada na escolha do usuário
double resultado = 0;
switch (operador)
{
    case "+": 
        resultado = primeiroNumero + segundoNumero;
        break;
    case "-":
        resultado = primeiroNumero - segundoNumero;
        break;
    case "/":
        resultado = primeiroNumero / segundoNumero;
        break;
    case "*":
        resultado = primeiroNumero * segundoNumero;
        break;
    default: 
        Console.WriteLine("Desculpe, mas não foi escolhida uma opção válida");
        break;
}   

//Apresentando o resultado ao usuário.
Console.WriteLine($"{primeiroNumero} {operador} {segundoNumero} = {resultado}\n");

//Criando uma lista e utilizando foreach para apresentar os itens da lista.
List<string>bandas = new List<string>()
{
    "Iron Maiden",
    "Metallica",
    "Megadeth"
};
bandas.Add("Pink Floyd");
bandas.Add("Led Zeppelin");

foreach (string banda in bandas)
{
    Console.WriteLine(banda);
};

//Criação da lista de números e apresentação para o usuário.
List<int>listaNumerica = new List<int>()
{
    1, 2, 5, 8
};

int somaNumeros = 0;
foreach (int numero in listaNumerica)
{
    somaNumeros += numero;
}
Console.WriteLine($"\nO resultado da soma dos números da lista é {somaNumeros}");