using ByteBankIO.Models;
public class UtilizandoStreamReader
{
    public List<ContaCorrente> LerContas(string enderecoArquivo)
    {
        var listaDeContas = new List<ContaCorrente>();

        using (var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        using (var leitor = new StreamReader(fluxoDoArquivo))
        {
            //var integraTexto = leitor.ReadToEnd();
            //var primeiroByte = leitor.Read();
            //var ultimaLinha = leitor.EndOfStream;

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConversorContaCorrente(linha!);
                listaDeContas.Add(contaCorrente);
            }
        }
        return listaDeContas;
    }

    static ContaCorrente ConversorContaCorrente(string linha)
    {
        var dados = linha.Split(',');
        var agencia = int.Parse(dados[0]);
        var numero = int.Parse(dados[1]);
        var saldo = double.Parse(dados[2].Replace('.', ','));
        var titular = new Cliente();
        
        titular.Nome = dados[3];
        
        var conta = new ContaCorrente(agencia, numero);
        conta.Titular = titular;
        conta.Depositar(saldo); 

        return conta;
    }
}
