namespace CatalogacaoDeItens.Models;
abstract class ItemDigital
{
    protected string Titulo { get;}
    public ItemDigital(string titulo)
    {
        Titulo = titulo;
    }
}
