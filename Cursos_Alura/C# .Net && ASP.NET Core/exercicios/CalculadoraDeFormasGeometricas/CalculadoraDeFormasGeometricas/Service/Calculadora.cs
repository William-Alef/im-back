using CalculadoraDeFormasGeometricas.Models;

namespace CalculadoraDeFormasGeometricas.Service;
internal static class Calculadora
{
    public static FormaGeometrica CriaForma(int opcao)
    {
        switch(opcao)
        {
            case 1:
                Console.Clear();
                Console.Write("Qual o raio do círculo: ");
                double raio = double.Parse(Console.ReadLine()!);
                return new Circulo(raio);
            case 2:
                Console.Clear();
                Console.Write("Qual o lado do quadrado: ");
                double lado = double.Parse(Console.ReadLine()!);
                return new Quadrado(lado);
            case 3:
                Console.Clear();
                Console.Write("Qual a base do triângulo: ");
                double baseA = double.Parse(Console.ReadLine()!);    
                Console.Write("Qual a altura do triângulo: ");
                double altura = double.Parse(Console.ReadLine()!);   
                Console.Write("Qual o lado A do triângulo: ");
                double ladoA = double.Parse(Console.ReadLine()!);
                Console.Write("Qual o lado B do triângulo: ");
                double ladoB = double.Parse(Console.ReadLine()!);
                Console.Write("Qual o lado C do triângulo: ");
                double ladoC = double.Parse(Console.ReadLine()!);
                return new Triangulo(baseA,altura,ladoA, ladoB, ladoC);
            default:
                Console.Clear();
                throw new ArgumentException("Opção inválida");
        }
        throw new NotImplementedException();
    }
}
