namespace ManipulandoStrings.Services;
internal static class StringComparerServices
{
    public static void CompararStrings(string primiraString, string segundaString)
    {
        var resultadoSemComparison = primiraString.Equals(segundaString);
        var resultadoComComparison = primiraString.Equals(segundaString, StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"Resultado sem utilizar o enumerador StringComparison: {resultadoSemComparison}");
        Console.WriteLine($"Resultado utilizando o enumerador StringComparison: {resultadoComComparison}");
    }
}
