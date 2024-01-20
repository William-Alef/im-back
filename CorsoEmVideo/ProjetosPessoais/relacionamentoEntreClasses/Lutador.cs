using System.Data.Common;

public class Lutador : ILutador
{
    private string Nome { get; set; }
    private string Nacionalidade { get; set; }
    private int Idade { get; set; }
    private float Altura { get; set; }
    private string Categoria { get; set; } = "";
    private int Vitorias { get; set; }
    private int Derrotas { get; set; }
    private int Empates { get; set; }
    private float _peso;
    private float Peso
    {
        get => _peso;
        set
        {
            _peso = value;

            if (_peso < 52.2)
            {
                Categoria = "Invalido";
            }
            else if (_peso <= 70.3)
            {
                Categoria = "Leve";
            }
            else if (_peso <= 83.9)
            {
                Categoria = "Medio";
            }
            else if (_peso <= 120.2)
            {
                Categoria = "Pesado";
            }
            else
            {
                Categoria = "Invalido";
            }
        }
    }

    public string ObterCategoria()
    {
        return this.Categoria;
    }
    public string ObterNome()
    {
        return this.Nome;
    }
    public Lutador(string nome, string nacionalidade, int idade, float altura, float peso, int vitorias, int derrotas, int empates)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Altura = altura;
        Peso = peso;
        Vitorias = vitorias;
        Derrotas = derrotas;
        Empates = empates;
    }
    public void Apresentar()
    {
        System.Console.WriteLine($"\nCHEGOU O GRANDE MOMENTO!\nApresentamos o lutador {Nome}\nDiretamente do(a) {Nacionalidade}\nCom {Idade} anos e {Altura} metros\nPesando {Peso}Kg\nGanhou: {Vitorias} lutas, perdeu {Derrotas} e empatou {Empates}!");
    }

    public void GanharLuta()
    {
        this.Vitorias +=1;
    }

    public void PerderLuta()
    {
        this.Derrotas +=1;
    }

        public void EmpatarLuta()
    {
        this.Empates +=1;
    }

    public void Status()
    {
        System.Console.WriteLine($"O lutador {Nome} é um peso {Categoria}\nCom {Vitorias} vitórias, {Derrotas} derrotas e {Empates} empates.");
    }
}
