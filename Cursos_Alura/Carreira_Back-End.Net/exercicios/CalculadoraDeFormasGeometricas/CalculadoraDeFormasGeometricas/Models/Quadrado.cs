namespace CalculadoraDeFormasGeometricas.Models;

internal class Quadrado : FormaGeometrica
{
    private double _lado;

    public Quadrado(double lado)
    {
        _lado = lado; 
    }
    public override double CalcularArea() => Math.Pow(_lado, 2); 
    public override double CalcularPerimetro() => 4 * _lado;
}
