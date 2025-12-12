
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.Text;

namespace GeradorDeRelatorios.Gerators;
public class GeradorDeRelatoriosPDF : GeradorDeRelatorioBase
{
    public GeradorDeRelatoriosPDF(List<Dictionary<string, string>> input) : base(input){}

    public override string GerarRelatorio()
    {
        if(Input == null || Input.Count == 0) throw new Exception("Input inválido.");

        StringBuilder builder = new StringBuilder();

        using var escritor = new PdfWriter("relatorio.pdf");
        using var pdf = new PdfDocument(escritor);
        using var documento = new iText.Layout.Document(pdf);

        if (!string.IsNullOrEmpty(Titulo))
        {
            var titulo = new iText.Layout.Element.Paragraph(Titulo)
                .SetFontSize(20)
                .SetBold()
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetMargin(10);
            documento.Add(titulo);
        }

        if (!string.IsNullOrEmpty(Cabecalho))
        {
            var cabecalho = new iText.Layout.Element.Paragraph(Cabecalho)
                .SetFontSize(16)
                .SetItalic()
                .SetMarginBottom(10);
            documento.Add(cabecalho);
        }

        Table tabela = new Table(Input.First().Keys.Count);
        foreach (var cabecalho in Input.First().Keys)
        {
            tabela.AddHeaderCell(new Cell().Add(new Paragraph(cabecalho).SetBold()));
        }

        foreach (var dicionario in Input)
        {
            foreach (var linha in dicionario.Values)
            {
                tabela.AddCell(new Cell().Add(new Paragraph(linha)));
            }
        }
        documento.Add(tabela);
        if (!string.IsNullOrEmpty(Rodape))
        {
            var rodape = new iText.Layout.Element.Paragraph(Rodape)
                .SetFontSize(12)
                .SetMarginTop(10);
            documento.Add(rodape);
        }

        return Path.GetFullPath("relatorio.pdf");
    }
}
