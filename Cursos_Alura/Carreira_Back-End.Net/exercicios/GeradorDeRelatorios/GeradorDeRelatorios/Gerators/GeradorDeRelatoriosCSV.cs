using GeradorDeRelatorios.Util;
using System.Text;

namespace GeradorDeRelatorios.Gerators
{
    public class GeradorDeRelatoriosCSV : GeradorDeRelatorioBase
    {
        public List<Dictionary<string, string>> Input { get; set; }
        public string Titulo { get; set; }
        public string Cabecalho { get; set; }
        public string Rodape { get; set; }

        public GeradorDeRelatoriosCSV(List<Dictionary<string, string>> input) : base(input){}

        public override string GerarRelatorio()
        {
            if (Input == null || Input.Count == 0) throw new Exception("Input inválido!");

            StringBuilder relatorio = new StringBuilder();
            if (!string.IsNullOrEmpty(Titulo))
            {
                relatorio.AppendLine(Titulo);
                relatorio.AppendLine("");
            }

            if (!string.IsNullOrEmpty(Cabecalho))
            {
                relatorio.AppendLine(Cabecalho);
                relatorio.AppendLine("");
            }
            string cabecalho = string.Join(';',Input.First().Keys);
            relatorio.AppendLine(cabecalho);

            foreach (var item in Input)
            {
                string linha = string.Join(';', item.Values);
                relatorio.AppendLine(linha);
            }

            if (!string.IsNullOrEmpty(Rodape))
            {
                relatorio.AppendLine("");
                relatorio.AppendLine(Rodape);
            }
            
            FormatadorData data = new FormatadorData();
            relatorio.AppendLine(data.FormatarData(DateTime.Now.ToString()));

            File.WriteAllText("Relatorio.csv", relatorio.ToString(), Encoding.UTF8);
            return Path.GetFullPath("Relatorio.csv");
        }
    }
}
