namespace ByteBankIO;
public class LidandoDiretamenteComStreamDeEntrada
{
    public static void UsandoStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("DadosProvidosPeloUsuario", FileMode.Create))
        {
            var buffer = new byte[1024];
            while (true)
            {
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                Console.Write($"Quantidade de bytes lidos: {bytesLidos}\n");
                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();
            }
        }
    }
}
