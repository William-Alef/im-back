namespace ByteBankIO.Services;
public class EscritorECriadorBinario
{ 
    public static void EscritorBinario(string enderecoAquvo)
    {
        using (var fluxoArquivo = new FileStream(enderecoAquvo, FileMode.Create))
        using (var escritor = new BinaryWriter(fluxoArquivo))
        {
            escritor.Write(432);
            escritor.Write(3243);
            escritor.Write(1029.0);
            escritor.Write("Jorge Amado");
            escritor.Flush();
        }
    }
    public static void LeitorBinario(string enderecoArquivo)
    {
        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        using (var leitor = new BinaryReader(fluxoArquivo))
        {
            var agencia = leitor.ReadInt32();
            var numero = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();
            Console.WriteLine($"Dados lidos: Titular {titular} - Agência {agencia} - Número {numero} - Saldo {saldo}");
        }
    }
}
