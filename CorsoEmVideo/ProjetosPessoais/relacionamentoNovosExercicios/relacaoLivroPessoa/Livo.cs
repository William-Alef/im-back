using System.Data.Common;

class Livro(string titulo, string autor, int totalPaginas, Pessoa leitor) : Ipublicacao
{
    private string Titulo {get;set;} = titulo;
    private string Autor {get;set;} = autor;
    private int TotalPag {get;set;} = totalPaginas;
    private int PagAtual {get;set;} = 0;
    private bool Aberto {get;set;} = false;
    private Pessoa Leitor {get;set;} = leitor;

    public void Abrir()
    {
        if(!this.Aberto)
        {
            this.Aberto = true;
        }
        else
        {
            System.Console.WriteLine("O livro já está aberto.");
        }
    }
    public void Fechar()
    {
        if(Aberto)
        {
            this.Aberto = false;
        }
        else
        {
            System.Console.WriteLine("O livro já está fechado.");
        }
    }

    public void AvancarPag()
    {
        if(this.Aberto && this.PagAtual != this.TotalPag)
        {
            this.PagAtual += 1;
        }
        else
        {
            System.Console.WriteLine("Não é possível avançar as páginas de um livro fechado ou totalmente lido.");
        }
    }
    public void VoltarPag()
    {
        if(this.Aberto && this.PagAtual != 0)
        {
            this.PagAtual -= 1;
        }
        else
        {
            System.Console.WriteLine("Não é possível retroceder as páginas de um livro fechado ou em sua primeira página.");
        }
    }

    public void Detalhes()
    {
        System.Console.WriteLine($"Título: {Titulo}\nAutor: {Autor}\nTotal de páginas: {TotalPag}\nPágina atual: {PagAtual}\nAberto: {Aberto}\nLeitor: {Leitor.ApresentarNome()}");
    }

    public void Folhear()
    {
        if(this.Aberto){
            Random random = new Random();
            int folheando = random.Next(0, TotalPag);
            this.PagAtual = folheando;
        }
        else{
            System.Console.WriteLine("Não é possível folhear um livro fechado.");
        }
    }
}