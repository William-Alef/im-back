
namespace GeradorDeRelatorios.Gerators;
/// <summary>
/// Classe base que define a estrutura fundamental para geradores de relatório.
/// Fornece propriedades comuns e exige a implementação de um método de geração de relatório.
/// </summary>
public abstract class GeradorDeRelatorioBase : IGeradorDeRelatorios
{
    /// <summary>
    /// Coleção de arquivos carregar a partir de um arquivo CSV.
    /// Cada dicionário representa uma linha, onde a chave é o cabeçalho da coluna e o valor será o conteúdo da célula.
    /// </summary>
    public List<Dictionary<string, string>> Input { get; set; }
    /// <summary>
    /// String que define o título do relatório gerado.
    /// </summary>
    public string Titulo { get ; set; }
    /// <summary>
    /// String que define o cabeçalho do relatório gerado.
    /// </summary>
    public string Cabecalho { get; set; }
    /// <summary>
    /// String que define o rodapé do relatório gerado.
    /// </summary>
    public string Rodape { get; set; }

    /// <summary>
    /// Construtor base que recebe a lista de dicionários como argumento de entrada padrão.
    /// </summary>
    /// <param name="input"></param>
    public GeradorDeRelatorioBase(List<Dictionary<string, string>> input)
    {
        Input = input;
    }

    /// <summary>
    /// Método responsável por gerar o relatório final.
    /// O método deverá ser implementado pelas classes que herdam esta classe.
    /// </summary>
    /// <returns>
    /// Caminho completo do arquivo gerado ou o conteúdo final do mesmo.
    /// </returns>
    public abstract string GerarRelatorio();
}
