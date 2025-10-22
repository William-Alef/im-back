using CriandoEConsumindoArquivos.Models;
namespace CriandoEConsumindoArquivos.Services;

public class ManipuladorArquivoCSV
{
    public List<Carro> LerArquivo(string enderecoArquivo)
    {
        var listaDeCarros = new List<Carro>();
        using(var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        using(var leitor = new StreamReader(fluxoDoArquivo))
        {
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                listaDeCarros.Add(ConverterDadosEmCarros(linha!));
            }
        }
        return listaDeCarros;
    }

    public void EscreverArquivo()
    {
        Console.Write("Entre com o endereço do arquivo: ");
        string enderecoArquivo = Console.ReadLine()!;

        using(var fluxoDoArquvo = new FileStream(enderecoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquvo))
        {
            int quantidadeDesejada = 0;
            Console.Write("Quantos itens deseja adicionar: ");
            quantidadeDesejada = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\nNecessário informar os dados conforme o exemplo a seguir, na hordem marca, modelo, cor, cavalos, valor e velocidade máxima. Ex: Hyundai,HB20,Preto,80,90990.00,165.\n");
            
            for(int i = 0; i < quantidadeDesejada; i++)
            {
                Console.Write($"Entre com os dados do {i+1} veículo: ");
                string dados = Console.ReadLine()!;
                escritor.WriteLine(dados); 
                escritor.Flush();
            }
            Console.WriteLine("Lista criada com sucesso!");
        }
    }

    private Carro ConverterDadosEmCarros(string linha)
    {
        var dados = linha.Split(',');
        var marca = dados[0];
        var modelo = dados[1];
        var cor = dados[2];
        var cavalos = int.Parse(dados[3]);
        var valor = decimal.Parse(dados[4], System.Globalization.CultureInfo.InvariantCulture);
        var velocidadeMaxima = int.Parse(dados[5]);

        Carro carro = new Carro(marca, modelo, cor, cavalos, valor, velocidadeMaxima);
        return carro;
    }
}
    