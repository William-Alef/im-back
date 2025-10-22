namespace ScreenSound.Models;

internal class Avaliacao
{
    public double Nota { get; set; }
    public Avaliacao(double nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }

    public static Avaliacao Parse(string Texto) 
    {
        double nota = double.Parse(Texto);
        return new Avaliacao(nota);
    }
}

