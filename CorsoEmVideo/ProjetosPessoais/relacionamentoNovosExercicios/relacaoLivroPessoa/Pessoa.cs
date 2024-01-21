using System.Reflection.Emit;

class Pessoa (string nome, int idade, string sexo)
{
    private string Nome {get; set;} = nome;
    private int Idade {get; set;} = idade;
    private string Sexo {get; set;} = sexo;

    public void FazerAniversario()
    {
        this.Idade ++;
        System.Console.WriteLine($"Parabéns {Nome}, agora você tem {this.Idade} anos!");
        
    }
    public string ApresentarNome(){
        return this.Nome;
    }
}