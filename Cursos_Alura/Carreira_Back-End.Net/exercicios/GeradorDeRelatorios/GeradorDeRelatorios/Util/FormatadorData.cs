namespace GeradorDeRelatorios.Util
{
    internal class FormatadorData : IFormatadorDeData
    {
        public string FormatarData(string data)
        {
           if(DateOnly.TryParse(data, out var date))
           {
                return date.ToString("dd/MM/yyyy");
           }
           return data;
        }
    }
}
