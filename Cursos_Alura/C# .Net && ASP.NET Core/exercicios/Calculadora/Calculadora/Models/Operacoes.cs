namespace Calculadora.Models;

internal class Operacoes(double valorA, double ValorB, string operador)
{
    public double ValorA { get; set; } = valorA;
    public double ValorB { get; set; } = ValorB;
    public string Operador { get; set; } = operador;
    public double Calculadora()
    {
        switch(Operador)
        {
            case "+": return ValorA + ValorB;
            case "-": return ValorA - ValorB;
            case "*": return ValorA * ValorB;
            case "/": return ValorB != 0 ? ValorA / ValorB : throw new DivideByZeroException("Não é possível realizar a divisão por zero.");
            case "**": return Math.Pow(ValorA, ValorB);
            case "sqr": return Math.Sqrt(ValorA);
            default: throw new InvalidOperationException("Operador inválido.");
        }
    }
}
