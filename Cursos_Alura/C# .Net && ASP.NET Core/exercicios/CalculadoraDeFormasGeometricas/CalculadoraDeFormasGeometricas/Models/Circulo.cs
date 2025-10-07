using System;

namespace CalculadoraDeFormasGeometricas.Models;
internal class Circulo : FormaGeometrica
{
    private double _raio, pi = Math.PI;
    
    public Circulo(double raio) 
    {
        _raio = raio;
    }
    public override double CalcularArea() => pi * (_raio * _raio);
    public override double CalcularPerimetro() => 2 * pi * _raio;
}
