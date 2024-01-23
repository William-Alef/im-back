class Funcionario : Pessoa
{
    private string Setor {get; set;}
    private bool Trabalhando {get; set;} // //

    public Funcionario (string nome, int idade, string sexo, string setor) : base(nome, idade, sexo)
    {
        Setor = setor;
        Trabalhando = false;
    }
    public void MudarTrabalho()
    {
        if(Trabalhando)
        {
            this.Trabalhando = false;
            System.Console.WriteLine(this.Trabalhando);
        }
        else
        {
            this.Trabalhando = true;
            System.Console.WriteLine(this.Trabalhando);
        }
    }
}
