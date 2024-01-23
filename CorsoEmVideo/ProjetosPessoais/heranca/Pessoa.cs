public class Pessoa
{

    private string Nome {get; set;}
    private int Idade {get; set;}
    private string Sexo {get; set;}

    public Pessoa(string nome, int idade, string sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public void FazerAniversario(){
        this.Idade ++;
    }
}