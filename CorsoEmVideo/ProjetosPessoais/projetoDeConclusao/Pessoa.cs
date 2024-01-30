public abstract class Pessoa
{
    protected string Nome {get; set;}
    protected int Idade {get; set;}
    protected string Sexo {get; set;}
    protected float Experiencia {get; set;}

    public Pessoa(string nome, int idade, string sexo)
    {
        this.Nome = nome;
        this.Idade = idade;
        this. Sexo = sexo;
        this.Experiencia = 0;
    }

    protected void GanharExp()
    {

    }
    public string ApresentaNome()
    {
        return this.Nome;
    }
    public int ApresentaIdade()
    {
        return this.Idade;
    }
    public string ApresentaSexo()
    {
        return this.Sexo;
    }
    public float ApresentaXP()
    {
        return this.Experiencia;
    }
}