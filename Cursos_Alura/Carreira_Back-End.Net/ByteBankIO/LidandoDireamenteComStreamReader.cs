using System.Text;

partial class LidandoComFileStream
{
    static void LidandoDireamenteComFileStream()
    {
        var enderecoArquivo = "contas.txt";
        var contadorDeBytesLidos = -1;

        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var buffer = new byte[1024];
            while (contadorDeBytesLidos != 0)
            {
                contadorDeBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
                ApresentarBuffer(buffer, contadorDeBytesLidos);
            }
        }
    }

    static void ApresentarBuffer(byte[] buffer, int baytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, baytesLidos);
        Console.Write(texto);
    }
}