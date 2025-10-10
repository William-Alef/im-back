namespace CertificadoDeProfissoes.Models;
abstract class Profissao
{
    public string Titulo { get;}

    public Profissao(string titulo)
    {
        Titulo = titulo;
    }
}
