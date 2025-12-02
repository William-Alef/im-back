using ManipulandoStrings.Services;
public class Program
{
    static void Main(string[] args)
    {
        var arquivo = new FileStream(@"\\ManipulandoStrings\\ManipulandoStrings\\Data\\musicas.csv", FileMode.Open, FileAccess.Read);
        var stream = new StreamReader(arquivo);

        var musicas = MusicaServices.ObterMusica(stream)
            .Take(20);
        
        MusicaServices.ApresentarMusicas(musicas);
        MusicaServices.AlterarTitulo(stream, "Nova Moda");
        MusicaServices.ApresentarMusicasTabeladas(musicas);

        string nome = "William";
        int palavrasEmNome = nome.Count();
        string SegundoNome = "WILLIAM";
        StringComparerServices.CompararStrings(nome, SegundoNome);

        var senha = "aws";
        Console.WriteLine(SenhaServices.VerificarSenha(senha));

        var stringNaPool = "Internalizada"; //Por ser uma literal, o objeto é adicionado no espaço do HEAP dedicado ao String Pool.
        var ApontandoParaRefNaPool = "Internalizada"; //CLR reconhece que há um objeto que possúi as mesmas características e passa a pontar para o objeto da String Pool.
        var NovoNaPool = new string("Internalizada"); //Por forçar uma nova instanciação, o CLR trata ele como um novo objeto que não precisará ser verificado na string pool.
        var forcandoApontarParaPoolAnterior = string.Intern(stringNaPool); //Estamos forçando o objeto a apontar para a mesma referência de stringNaPool.
        Console.WriteLine(string.ReferenceEquals(stringNaPool, NovoNaPool));
        
    }
}