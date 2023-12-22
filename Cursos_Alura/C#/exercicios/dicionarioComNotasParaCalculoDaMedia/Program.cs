Dictionary<string, List<double>> notas = new Dictionary<string, List<double>>();

Console.Write("Qual a contidade de alunos: ");
int quantidadeAlunos = int.Parse(Console.ReadLine()!);

for (int i = 0; i < quantidadeAlunos; i++)
{
    Console.Write("Nome do aluno: ");
    string nome = Console.ReadLine()!;
    if(notas.ContainsKey(nome))
    {
        Console.WriteLine($"O aluno {nome} já consta em sistema, gostaria de adicionar uma nova nota para o mesmo?\nDigite (1) para Sim\n(2) para Não\n");
        int incluirNota = int.Parse(Console.ReadLine()!);
        
        if(incluirNota == 1)
        {
            Console.WriteLine("Quantas notas deseja atribuir ao aluno: ");
            int quantidadeNotas = int.Parse(Console.ReadLine()!);

            for (int ii = 0; ii < quantidadeNotas; ii++)
            {
                Console.Write($"Qual a nota do aluno {nome}: ");
                double novaNota = double.Parse(Console.ReadLine()!);
                notas[nome].Add(novaNota);
            }
        }

    }else
    {
        Console.Write($"Qual a nota do aluno {nome}: ");
        double nota = double.Parse(Console.ReadLine()!);
        notas.Add(nome, new List<double> {nota});
    }
    
}
/*
Console.WriteLine("Os alunos e suas notas são:\n");
for (int i = 0; i < notas.Count; i++)
{
    Console.WriteLine($"{notas.Keys.ElementAt(i)} com a nota {notas.Values.ElementAt(i)}");
    
}
*/