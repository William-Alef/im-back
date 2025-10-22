using System.ComponentModel.Design;
using System.Data;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
//Dictionary<string, List<String>> logins = new Dictionary<string, List<string>>();
Dictionary<string, string> logins = new Dictionary<string, string>();
Dictionary<string, string> quiz = new Dictionary<string, string>();
Dictionary<string, List<double>> notas = new Dictionary<string, List<double>>();
Dictionary<string, Tuple<int, double>> estoque = new Dictionary<string, Tuple<int, double>>();

void mensagemBoasVindas(string mensagem)
{
    Console.Clear();
    Console.Write(mensagem);
};

void opcoesMenu()
{
    try
    {
        mensagemBoasVindas("Bem vindo!\n\nDigite o número da ação desejada: \n(1) Para registrar alunos e suas notas\n(2) Gerenciamento do estoque de uma loja\n(3) Jogar Quiz\n(4) Sistema de login\n\nEscolha: ");
        int escolhaMenu = int.Parse(Console.ReadLine()!);

        switch (escolhaMenu)
        {
            case 1: gerenciamentoDeNotas();
            break;
            case 2: gerenciamentoDeEstoque();
            break;
            case 3: jogarQuiz();
            break;
            case 4: sistemaDeLogin();
            break;
            default: Console.WriteLine("\n\nOpção não aceita\nPor favor, Selecione uma opção válida."); Thread.Sleep(2000); opcoesMenu();
            break;
        };
    }
    catch (System.Exception)
    {
        Console.Write("Desculpe, mas não identificamos a opção desejada.\nRetornando ao menu."); Thread.Sleep(3000); opcoesMenu();
        throw;
    };
};

opcoesMenu();
void gerenciamentoDeNotas()
{
    try
    {
        Console.Clear();
        Console.Write("Bem vindo ao gerenciamento de notas!\n\nQual a quantidade de alunos: ");
        int quantidadeAlunos = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < quantidadeAlunos; i++)
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine()!;
            if(notas.ContainsKey(nome))
            {
                Console.Write($"O aluno {nome} já consta em sistema, gostaria de adicionar uma nova nota para o mesmo?\nDigite:\n\n(1) para Sim\n(2) para Não\nEscolha: ");
                int incluirNota = int.Parse(Console.ReadLine()!);
                Console.Clear();

                if(incluirNota == 1)
                {
                    Console.Write("Quantas notas deseja atribuir ao aluno: ");
                    int quantidadeNotas = int.Parse(Console.ReadLine()!);

                    for (int contador = 0; contador < quantidadeNotas; contador++)
                    {
                        Console.Write($"Qual a nota do aluno {nome}: ");
                        double novaNota = double.Parse(Console.ReadLine()!);
                        notas[nome].Add(novaNota);
                    }

                    Console.Write("Deseja calcular a média dos alunos: \n(1) Para sim\n(2) Para não\nEscolha: ");
                    int calcularMedia = int.Parse(Console.ReadLine()!);

                    if(calcularMedia == 1)
                    {
                        foreach (var aluno in notas)
                        {
                            List<double> notasAluno = aluno.Value;
                            double media = notasAluno.Count > 0 ? notasAluno.Average() : 0;
                            Console.WriteLine($"\n{nome} com média {media}");
                        }
                    }
                }
            }else
            {  
                Console.Write($"Qual a nota do aluno {nome}: ");
                double nota = double.Parse(Console.ReadLine()!);
                notas.Add(nome, new List<double> {nota});
            }
        }
        Console.WriteLine("Alunos adicionados: ");
        foreach (var aluno in notas)
        {
            Console.WriteLine($"\n{aluno.Key} com as notas: {string.Join(", ", aluno.Value)}");
        }  
        Console.WriteLine("Voltando ao menu inicial.");
        Thread.Sleep(2000);
        opcoesMenu();
    }
    catch (System.Exception)
    {
        Console.WriteLine("Desculpe, mas houve um erro com os dados informados.\nRetornando ao menu do gerenciamento de notas."); Thread.Sleep(3000); gerenciamentoDeNotas();
        throw;
    };
};

void gerenciamentoDeEstoque()
{
    try
    {
        mensagemBoasVindas("Bem vindo ao gerenciamento de estoque!\nDigite o número da ação desejada:\n\n(1) Adicionar produtos em estoque\n(2) Atualizar um produto\n(3) Apresentar produtos registrados\n(4) Voltar ao menu inicial\n\nEscolha: ");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 1: adicionarProdutos();
            break;
            case 2: atualizarProdutos();
            break;
            case 3: apresentarProdutos();
            break;
            case 4: mensagemBoasVindas("Voltando ao menu inicial"); Thread.Sleep(3000); opcoesMenu();
            break;
            default: mensagemBoasVindas("Por favor, entre com um valor válido."); Thread.Sleep(3000); gerenciamentoDeEstoque();
            break;
        }

        void adicionarProdutos()
        {
            mensagemBoasVindas("Adicionando produtos\n\nQual a quantidade de protudos a serem adicionados: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.Write($"Qual o nome do {i+1} produto: ");
                string nomeProduto = Console.ReadLine()!;
                Console.Write("Qual a quantidade inicial do produto em estoque: ");
                int quantidadeProduto = int.Parse(Console.ReadLine()!);
                Console.Write("Qual o valor unitário para este item: ");
                double valorDoProduto = double.Parse(Console.ReadLine()!);

                Tuple<int, double> valoresProdutos = Tuple.Create(quantidadeProduto, valorDoProduto);
                estoque.Add(nomeProduto.ToLower(), valoresProdutos);
                Console.Clear();
            };
            mensagemBoasVindas("Produtos adicionados!\nRetornando ao menu do estoque."); Thread.Sleep(3000); gerenciamentoDeEstoque();
        };

        void atualizarProdutos()
        {
            mensagemBoasVindas("Atualizando produtos\n\nNome do produto a ser atualizado: ");
            string nomeDoProduto = Console.ReadLine()!.ToLower();
            if(!estoque.ContainsKey(nomeDoProduto))
            {
                Console.Write("Desculpe, não temos este produto em sistema.\nRetornando ao menu do estoque."); Thread.Sleep(3000); gerenciamentoDeEstoque();
            }else
            { 
                mensagemBoasVindas("Produto localizado!\nDigite o número da ação desejada: \n\n(1) Atulizar a quantidade\n(2) Atualizar o valor\n(3) Atualizar quantidade e valor\n(4) Voltar ao menu do estoque\nEscolha: ");
                int escolhaAtualizacao = int.Parse(Console.ReadLine()!);
                switch (escolhaAtualizacao)
                {
                    case 1: atualizarQuantidade();
                    break;
                    case 2: atualizarValor();
                    break;
                    case 3: atualizarQuantidadeValor();
                    break;
                    case 4: Console.Write("Voltando ao menu do estoque"); Thread.Sleep(3000); gerenciamentoDeEstoque();
                    break;
                    default: Console.Write("Desculpe, mas não foi celecionada nenhuma opção válida.\nRetornando ao menu do estoque."); Thread.Sleep(3000); gerenciamentoDeEstoque();
                    break;
                };
                
                void atualizarQuantidade()
                {
                    mensagemBoasVindas("Qual a nova quantidade em estoque: ");
                    int novaQuantidade = int.Parse(Console.ReadLine()!);
                    foreach (var produto in estoque)
                    {
                        double valor = produto.Value.Item2; 
                        var tuplaAtual = estoque[nomeDoProduto];
                        var novaTupla = Tuple.Create(novaQuantidade, valor);
                        estoque[nomeDoProduto] = novaTupla; 
                        mensagemBoasVindas("Cadastro de produto atualizado!\nRetornando ao menu do estoque."); Thread.Sleep(3000); gerenciamentoDeEstoque();
                    };
                };

                void atualizarValor()
                {
                    mensagemBoasVindas("Qual o novo valor para este produto: ");
                    double novoValor = double.Parse(Console.ReadLine()!);
                    foreach (var produto in estoque)
                    {
                        int quantidadeProduto = produto.Value.Item1;
                        var tuplaAtual = estoque[nomeDoProduto];
                        var novaTupla = Tuple.Create(quantidadeProduto, novoValor);
                        estoque[nomeDoProduto] = novaTupla; 
                        mensagemBoasVindas("Cadastro de produto atualizado!\nRetornando ao menu do estoque."); Thread.Sleep(3000); gerenciamentoDeEstoque();
                    };
                };

                void atualizarQuantidadeValor()
                {
                    mensagemBoasVindas("Qual a nova quantidade em estoque: ");
                    int novaQuantidade = int.Parse(Console.ReadLine()!);
                    mensagemBoasVindas("Qual o novo valor para este produto: ");
                    double novoValor = double.Parse(Console.ReadLine()!);

                    var tuplaAtual = estoque[nomeDoProduto];
                    var novaTupla = Tuple.Create(novaQuantidade, novoValor);
                    estoque[nomeDoProduto] = novaTupla; 
                    mensagemBoasVindas("Atualização realizada!\nRetornando ao menu do estoque."); Thread.Sleep(3000); gerenciamentoDeEstoque();
                };
            };
        };

        void apresentarProdutos()
        {
            mensagemBoasVindas("Produtos em sistema, suas quantidaes e valores:\n\n");
            Console.WriteLine($"Temos em sistema {estoque.Count} produtos registrados\n");
            foreach (var produto in estoque)
            {
                string nome = produto.Key;
                int quantidade = produto.Value.Item1;
                double valor = produto.Value.Item2;
                Console.Write($"Nome: {nome}\nQuantidade em estoque: {quantidade}\nValor unitário: {valor}\n\n");

            };
            Console.WriteLine("Pressione qualquer botão para retornar ao menu do estoque."); 
            Console.ReadKey(); gerenciamentoDeEstoque();
        };        
    }
    catch (System.Exception)
    {
        Console.WriteLine("Desculpe, mas houve um erro com os dados informados.\nRetornando ao menu do gerenciamento de notas."); Thread.Sleep(3000); gerenciamentoDeEstoque();
        throw;
    };
};

void jogarQuiz()
{
    try
    {
        mensagemBoasVindas("Bem vindo ao jogo do Quiz!\n\nDigite o número da opção desejada:\n(1) Registrar perguntas e respostas\n(2) Jogar Quiz\n(3) Voltar ao menu inicial\n\nEscolha: ");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {   
            case 1: registrarQuiz();
            break;
            case 2: jogar();
            break;
            case 3: Console.WriteLine("Voltando ao menu inicial."); Thread.Sleep(3000); opcoesMenu();
            break;
            default: Console.WriteLine("Por favor, entre com um valor válido"); Thread.Sleep(3000); jogarQuiz();
            break;

            void registrarQuiz()
            {
                mensagemBoasVindas("Qual a quantidade de perguntas: ");
                int quantidadeQuiz = int.Parse(Console.ReadLine()!);
                Console.Clear();

                for (int i = 0; i < quantidadeQuiz; i++)
                {
                    Console.Write($"Qual a pergunda para o {i+1} Quiz: ");
                    string perguntaQuiz = Console.ReadLine()!;
                    Console.Write($"Qual a resposta para {i+1} Quiz: ");
                    string respostaQuiz = Console.ReadLine()!;
                    quiz.Add(perguntaQuiz, respostaQuiz);
                };
                mensagemBoasVindas("Perguntas e respostas registradas com sucesso!\nVoltando ao menu do jogo."); Thread.Sleep(3000);
                jogarQuiz();
            };
            void jogar(){
                mensagemBoasVindas("Então vamos jogar!\n\n");
                foreach (var pergunta in quiz.Keys)
                {
                    Console.WriteLine($"Pergunta: {pergunta}");
                    Console.Write("Resposta: ");
                    string resposta = Console.ReadLine()!;

                    if (resposta.ToLower() == quiz[pergunta].ToLower())
                    {
                        Console.WriteLine("Correto!\n");
                    }
                    else
                    {
                        Console.WriteLine($"Incorreto. A resposta correta é: {quiz[pergunta]}\n");
                    };
                };
                Thread.Sleep(3000);
                mensagemBoasVindas("O jogo terminou!\n\nVoltando ao menu do jogo!"); Thread.Sleep(3000);
                registrarQuiz();
            };
        }; 
    }
    catch (System.Exception)
    {
        Console.WriteLine("Desculpe, mas houve um erro com os dados informados.\nRetornando ao menu do gerenciamento de notas."); Thread.Sleep(3000); jogarQuiz();
        throw;
    };
};

void sistemaDeLogin()
{
    try
    {
        mensagemBoasVindas("Bem vindo ao sistema de login!\nDigite o número da opção desejada\n(1) Criar login e senha\n(2) Entrar com login e senha\n(3) Voltar ao menu\n\nEscolha: ");
        int escolhaLogin = int.Parse(Console.ReadLine()!);
        switch (escolhaLogin)
        {
            case 1: criarLogin();
            break;
            case 2: entrarComLogin();
            break;
            case 3: Console.WriteLine("Voltando ao menu inicial."); opcoesMenu();
            break;
            default: Console.WriteLine("Por favor, entre com um valor válido"); sistemaDeLogin();
            break;
        }

        void criarLogin(){
            Console.Write("Login: ");
            string usuario = Console.ReadLine()!;

            Console.Write("Senha: ");
            string senha = Console.ReadLine()!;
            
            string confirmaSenha = "";
            int contador = 0;
            do
            {
                if (contador > 1)
                {
                    Console.WriteLine("\nSenha de confirmação errada!");
                }
                Console.Write("Confirme a senha: ");
                confirmaSenha = Console.ReadLine()!;   
                contador++;

            }while(senha != confirmaSenha);

            logins.Add(usuario, senha);
            Console.WriteLine("\nUsuário criado com sucesso!");
            Console.WriteLine("Voltando ao menu de Login.");
            Thread.Sleep(3000);
            sistemaDeLogin();
        }
        void entrarComLogin()
        {
            string usuarioLogin = "";
            string senhaLogin = "";
            while(true)
            {
                Console.Write("Usuário: ");
                usuarioLogin = Console.ReadLine()!;
                Console.Write("Senha: ");
                senhaLogin = Console.ReadLine()!;

                if(logins.ContainsKey(usuarioLogin))
                {
                    string senhaArmazenada = logins[usuarioLogin];
                    if(senhaLogin.Equals(senhaArmazenada))
                    {
                        Console.WriteLine("\nLogin realizado com sucesso!\n");
                        Console.WriteLine("Voltando ao menu inicial.");
                        Thread.Sleep(2000);
                        opcoesMenu();
                        break;

                    }else
                    {
                        Console.WriteLine("\nSenha errada ou inexistente em nossa base!\n");
                    }
                }else 
                {
                    Console.WriteLine("\nUsuário errado ou inexistente em nossa base!\n");
                };
            };
        };
    }
    catch (System.Exception)
    {
        Console.WriteLine("Desculpe, mas houve um erro com os dados informados.\nRetornando ao menu do gerenciamento de notas."); Thread.Sleep(3000); sistemaDeLogin();
        throw;
    }
};