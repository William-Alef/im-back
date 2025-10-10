using SistemaDePagamentos.Models;

namespace SistemaDePagamentos;
public class Program
{
    static void Main(string[] args)
    {
        PagamentoCredito cliente1 = new PagamentoCredito("André", "andre@email.com");
        PagamentoBoleto cliente2 = new PagamentoBoleto("Juliana", "juliana@email.com");

        cliente1.ProcessarPagamento();
        cliente2.ProcessarPagamento();
    }
}