namespace ScreenSound_V4;
using GeradorDeRelatorios;
using System.Collections.Generic;

internal class GeradorCSV : GeradorDeRelatoriosCSV
{
    public GeradorCSV(List<Dictionary<string, string>> input) : base(input){}

    public string CSVGenerator(string nomeArquivo)
    {
        GerarRelatorio();
        File.Move("Relatorio.csv", nomeArquivo);
        return(Path.GetFullPath(nomeArquivo));
    }
}
