namespace MontagemDeMicros.Models;
internal class ComputadorPessoal
{
    public PlacaMae _placaMae { get; set; }
    public Processador _processador { get; set; }
    public PlacaDeVideo _placaDeVideo { get; set; }
    public Fonte _fonte { get; set; }
    public SolidStateDrive? _Ssd { get; set; }
    public HardDisck? _hd { get; set; }
    public WaterCooler? _waterCooler { get; set; }
    public AirCooler? _airCooler { get; set; }

    public ComputadorPessoal(PlacaMae placaMae, Processador processador, PlacaDeVideo placaDeVideo, Fonte fonte, SolidStateDrive ssd, HardDisck hd, WaterCooler waterCooler, AirCooler airCooler)
    {
        _placaMae = placaMae;
        _processador = processador;
        _placaDeVideo = placaDeVideo;
        _fonte = fonte;
        _Ssd = ssd;
        _hd = hd;
        _waterCooler = waterCooler;
        _airCooler = airCooler;
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine(
            $"\nDetalhes:\n" +
            $"\nPlaca mãe: {_placaMae}" +
            $"\nProcessador: {_processador}" +
            $"\nPraca de vídeo: {_placaDeVideo}" +
            $"\nFonte: {_fonte}" +
            $"{(_Ssd != null ? $"\nSSD: {_Ssd}" : string.Empty)}" +
            $"{(_hd != null ? $"\nHD: {_hd}" : string.Empty)}" +
            $"{(_waterCooler != null ? $"\nWaterCooler: {_waterCooler}" : string.Empty)}" +
            $"{(_airCooler != null ? $"\nAirCooler: {_airCooler}" : string.Empty)}" +
            $"\n---------------"
        );
    }
}
