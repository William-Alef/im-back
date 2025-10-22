using CertificadoDeProfissoes;
namespace CertificadoDeProfissoes.Models
{
    internal class Certificado
    {
        protected Profissao CertificadoProfissao { get; set; }
        public Certificado(Profissao profissao)
        {
            CertificadoProfissao = profissao;
        }

        public void ApresentarInformacoes()
        {
            Console.WriteLine(
                $"Certificado emitido para: {CertificadoProfissao.Titulo}"
            );
        }
    }
}
