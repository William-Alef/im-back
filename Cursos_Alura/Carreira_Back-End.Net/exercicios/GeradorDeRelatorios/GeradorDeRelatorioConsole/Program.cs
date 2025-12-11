using GeradorDeRelatorios;

List<Dictionary<string, string>> data = new()
{
    new Dictionary<string, string>
    {
        { "Nome", "Alice" },
        { "Idade", "30" },
        { "Cidade", "São Paulo" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Roberto" },
        { "Idade", "25" },
        { "Cidade", "Salvador" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Carlos" },
        { "Idade", "35" },
        { "Cidade", "Rio de Janeiro" }
    }
};

GeradorDeRelatoriosCSV relatorioCSV = new GeradorDeRelatoriosCSV(data);
relatorioCSV.Titulo = "Relatório de usuários";
relatorioCSV.Cabecalho = "Lista de usuários cadastradas no sistema";
relatorioCSV.Rodape = $"Quantidade de pessoas cadastradas: {data.Count}";

string caminho = relatorioCSV.GerarRelatorio();
Console.WriteLine($"Caminho completo do relatório: {caminho}");