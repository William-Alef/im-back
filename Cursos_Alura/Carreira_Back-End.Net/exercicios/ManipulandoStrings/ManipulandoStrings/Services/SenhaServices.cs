namespace ManipulandoStrings.Services;
internal static class SenhaServices
{
    public static string VerificarSenha(string senha)
    {
        bool senhaNula = senha is null;
        bool naoPossuiOitoCaracteres = senha.Count() < 8;
        int letrasMisculas = senha.Count(c => char.IsUpper(c));
        int letrasMinusculas = senha.Count(c => char.IsLower(c));
        int totalNumeros = senha.Count(c => char.IsDigit(c));
        int totalSimbolos = senha.Count(c => !char.IsLetterOrDigit(c));

        if (senhaNula
            || naoPossuiOitoCaracteres
            || letrasMinusculas <= 0
            || letrasMinusculas <= 0
            || totalNumeros <= 0
            || totalSimbolos <= 0) return "Senha inválida";
        return "Senha válida";
    }
        
}
