namespace CalculadoraDeFormasGeometricas.Models;
internal class Triangulo : FormaGeometrica
{
    private double _base, _altura, _ladoA, _ladoB, _ladoC;
    public Triangulo(double baseTriangulo, double altura, double ladoA, double ladoB, double ladoC)
    {
        _base = baseTriangulo;
        _altura = altura;
        _ladoA = ladoA;
        _ladoB = ladoB;
        _ladoC = ladoC;
    }
    public override double CalcularArea() => (_base * _altura) / 2;
    public override double CalcularPerimetro() => _ladoA + _ladoB + _ladoC;
}
