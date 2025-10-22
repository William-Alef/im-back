using System.Text;

namespace ByteBankIO;
partial class LidandoDiretamenteComStreamWriter
{
    public static void CriarArquivo(string dadosDoCliente)
    {
        var nomeArquivo = "ContasExportadas.csv";
        using(var fluxoDoArquivo = new FileStream(nomeArquivo, FileMode.Create))
        {
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(dadosDoCliente);
            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
            Console.WriteLine("Arquivo criado com sucesso!");
        }
    }
    public static void CriarArquivoComWriter()
    {
        var caminhoDoArquivo = "ContasExportadas.csv";
        using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.Write("538, 1931, 23212, Roberto");
        }
    }
    public static void TesteDeEscrita()
    {
        var caminhoDoArquivo = "ArquivoDeTeste.txt";
        using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            for (int i = 0; i < 100000; i++)
            {
                escritor.WriteLine($"linha {i}");
                Console.WriteLine($"linha {i} escrita com sucesso.\nPresione qualquer tecla...");
                escritor.Flush();
                Console.ReadKey();
            }
        }
    }
    
}
