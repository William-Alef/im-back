using DesserializacaoPais.Models;

namespace DesserializacaoPais.Services;
public class PaisService
{
    public void ApresentarPaises(List<Pais> listaPaises)
    {
        if(listaPaises != null && listaPaises.Count > 0)
        {
            foreach (var pais in listaPaises)
            {
                Console.WriteLine(
                    $"País: {pais.Nome}" +
                    $"\nCapital: {pais.Capital}" +
                    $"\nPopulação: {pais.Populacao}" +
                    $"\nIdioma falado: {pais.Idioma}"
                );
            }
        }
    }
    public void CompararPopulacao(List<Pais> listaPaises, string valor1, string valor2)
    {
        bool paisesValidos = valor1 != null && valor2 != null;

        if (listaPaises != null && listaPaises.Count > 0 
            && paisesValidos)
        {
            bool pais1NaLista = listaPaises.Any(p => p.Nome.Equals(valor1, StringComparison.OrdinalIgnoreCase));
            bool pais2NaLista = listaPaises.Any(p => p.Nome.Equals(valor2, StringComparison.OrdinalIgnoreCase));
            
            if (pais1NaLista && pais2NaLista)
            {
                var primeiroPais = listaPaises.First(p => p.Nome.Equals(valor1, StringComparison.OrdinalIgnoreCase));
                var segundoPais = listaPaises.First(p => p.Nome.Equals(valor2, StringComparison.OrdinalIgnoreCase));

                if(primeiroPais.Populacao > segundoPais.Populacao)
                {
                    Console.WriteLine($"A população do país {primeiroPais.Nome} é {primeiroPais.Populacao - segundoPais.Populacao} maior do que do {segundoPais.Nome}");
                }
                else if(segundoPais.Populacao > primeiroPais.Populacao)
                {
                    Console.WriteLine($"A população do país {segundoPais.Nome} é {segundoPais.Populacao - primeiroPais.Populacao} maior do que do {primeiroPais.Nome}");
                }
                else
                {
                    Console.WriteLine($"{primeiroPais.Nome} e {segundoPais.Nome} possuem uma populsação equivalente.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Um ou mais países informados não foram encontrados na lista.");
                return;            
            }
        }
        else
        {  
            Console.WriteLine("A lista fornecida está vazia.");
            return;
        }
    }
}
