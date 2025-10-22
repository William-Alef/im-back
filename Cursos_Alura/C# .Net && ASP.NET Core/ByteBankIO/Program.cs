using ByteBankIO;
using ByteBankIO.Models;
using ByteBankIO.Services;
partial class Program
{
    static void Main(string[] args)
    {
        /*
        var enderecoArquivo = "contas.txt";
        var leitorService = new UtilizandoStreamReader();
        List<ContaCorrente> contasLidas = leitorService.LerContas(enderecoArquivo);

        foreach (var conta in contasLidas)
        {
            Console.WriteLine($"Titular: {conta.Titular.Nome} - Conta: {conta.Numero}. Agência: {conta.Agencia}. Saldo: {conta.Saldo}");        
        }
        */
        //LidandoDiretamenteComStreamWriter.CriarArquivo("321, 0921, 20000, Mônica");
        //LidandoDiretamenteComStreamWriter.CriarArquivoComWriter();
        //LidandoDiretamenteComStreamWriter.TesteDeEscrita();
        //EscritorECriadorBinario.EscritorBinario("TesteDeBytes");
        //EscritorECriadorBinario.LeitorBinario("TesteDeBytes");
        LidandoDiretamenteComStreamDeEntrada.UsandoStreamDeEntrada();
    }

}       