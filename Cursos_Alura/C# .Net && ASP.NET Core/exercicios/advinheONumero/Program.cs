//Dando boas vindas e solicitando um chute.
Console.WriteLine("Bem vindo ao jogo da adivinhação! \nPor favor, chute um número de 1 a 100\n");

//Criando um numero randomico.
Random numeroRandomico = new Random();
int numeroSecreto = numeroRandomico.Next(1, 100);

do
{
    //Coletando o chute.
    Console.Write("Chute: ");
    string numeroInformado = Console.ReadLine()!;

    //Verificando se o chute é válido.
    if(int.TryParse(numeroInformado, out int chute))
    {
        //Verificando se o usuário acertou ou errou e trando os erros para dar uma dica ao usuário.
        if(chute == numeroSecreto)
        {
            Console.WriteLine("\nVocê acertou!");
            break;
        }
        else
        {
            switch (Math.Sign(chute - numeroSecreto))
            {
                case 1: Console.WriteLine("Seu chute é maior que o número secreto.");
                    break;
                case -1: Console.WriteLine("Seu chute é menor que o número secreto.");
                    break;    
            }
        }
    }
    else
    {
        Console.WriteLine("Por favor, informe um número válido.");
    }
    
} while (true);