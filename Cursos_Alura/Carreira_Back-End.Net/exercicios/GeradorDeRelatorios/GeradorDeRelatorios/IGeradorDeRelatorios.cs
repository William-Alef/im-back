namespace GeradorDeRelatorios
{
    /// <summary>
    /// Define o contrato para gerar relatórios com inputs, título,
    /// cabeçalho e rodapé customizáveis.
    /// </summary>
    public interface IGeradorDeRelatorios
    {
        /// <summary>
        /// Lista de dicionários contendo os inputs do relatório.
        /// </summary>
        public List<Dictionary<string, string>> Input{ get; set; }
        /// <summary>
        /// Título do relatório.
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Cabeçalho do relatório.
        /// </summary>
        public string Cabecalho{ get; set; }
        /// <summary>
        /// Rodapé do relatório.
        /// </summary>
        public string Rodape { get; set; }
        /// <summary>
        /// Gera e retorna o relatório como uma string.
        /// </summary>
        /// <returns>O relatório gerado.</returns>
        public string GerarRelatorio();
    }
}
