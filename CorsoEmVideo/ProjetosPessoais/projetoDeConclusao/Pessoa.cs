public abstract class Pessoa
{
    protected string Nome {get; set;}
    protected int Idade {get; set;}
    protected string Sexo {get; set;}
    protected float Experiencia {get; set;}

    public Pessoa(string nome, int idade, string sexo, float experiencia)
    {
        this.Nome = nome;
        this.Idade = idade;
        this. Sexo = sexo;
        this.Experiencia = experiencia;
    }

    protected void GanharExp()
    {

    }
}