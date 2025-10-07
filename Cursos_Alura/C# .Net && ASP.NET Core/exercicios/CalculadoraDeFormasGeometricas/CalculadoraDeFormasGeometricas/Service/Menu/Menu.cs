using CalculadoraDeFormasGeometricas.Models;

namespace CalculadoraDeFormasGeometricas.Service.Menu;

internal class Menu
{
    public static void Exibir()
    {
        while (true) 
        {
            Console.Clear();
            Console.Write(
                "1 - Círculo" +
                "\n2 - Quadrado" +
                "\n3 - Triângulo" +
                "\n0 - Sair" +
                "\n\nOpção desejada: "
            );

            if (!int.TryParse(Console.ReadLine(), out int opcao)) continue;
            if(opcao == 0) 
            { 
                Console.WriteLine("Saindo..."); 
                Thread.Sleep(1000); break;
            }
            try
            {
                FormaGeometrica forma = Calculadora.CriaForma(opcao);
                Console.WriteLine($"Área: {forma.CalcularArea():F2}\nPerimetro: {forma.CalcularPerimetro():F2}.");
            }
            catch(Exception EX)
            {
                Console.WriteLine($"Houve um erro: ERRO [{EX.Message}]");
            }
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
