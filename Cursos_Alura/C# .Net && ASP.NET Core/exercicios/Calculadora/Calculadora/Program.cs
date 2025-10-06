using Calculadora.Models;
using Microsoft.Win32.SafeHandles;
namespace Calculadora;

public class Program
{
    static void Main(string[] args)
    {
        string[] valores = new string[3];
        while (true)
        {
            Menu();
            valores = Console.ReadLine()!.Split(" ");
           
            if (valores.Length == 1 && valores[0].Trim().ToLower() == "sair")
            {
                Console.WriteLine("Saindo...");
                LimparTerminal();
                break;
            }
            if (valores.Length != 3)
            {
                Console.WriteLine("\n\nFORMATO INVÁLIDO! Por gentoleza, digite 3 elementos separados por um espaço, conforme o exemplo abaixo:\n 11 + 22\n\n");
                LimparTerminal();
                continue;
            }

            double valorA;
            double valorB;
            string operador = valores[1];
            
            bool passA = double.TryParse(valores[0], out valorA);
            bool passB = double.TryParse(valores[2], out valorB);
            if (!passA || !passB)
            {
                Console.WriteLine("\nERRO: Um ou mais valores não foram fornecidos corretamente.\n\n");
                LimparTerminal();
                continue;
            }

            try
            {
                Operacoes Calculo = new Operacoes(valorA, valorB, operador);
                Console.WriteLine($"Resultado: {Calculo.Calculadora()}\n\nAperte qualquer tecla para realizar um novo calculo");
                Console.ReadKey();
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine($"\n\nERRO: Houve um erro de operação. [{ex.Message}]\n\n");
                LimparTerminal();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"\n\nERRO: Houve um erro de operação [{ex.Message}] \n\n");
                LimparTerminal();
            }
            catch(Exception) { Console.WriteLine("ERRO: Houve um erro desconhecido."); LimparTerminal(); }
            Console.Clear();
        }
        Console.WriteLine("Até a próxima");

        static void LimparTerminal()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void Menu()
        {
            Console.Write("" +
                "Operações suportadas com exemplos:" +
                "\nAdição: 2 + 1." +
                "\nSubtração: 2 - 1." +
                "\nMultiplicação: 2 * 1." +
                "\nDivisão: 2 / 1." +
                "\nPotenciação: 2 ** 1." +
                "\nRadiação: 2 sqr 0." +
                "\nEntre com os valores e o símbolo da operação desejada separados por um espaço, conforme exemplo acima" +
                "\n\nDigite os valores: "
            );
        }
    }
}
