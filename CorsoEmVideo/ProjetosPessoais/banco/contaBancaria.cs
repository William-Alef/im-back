using System.Buffers;
using System.Data.Common;
using System.Reflection.Emit;
using System.Reflection.Metadata;


class ContaBancaria(int Numconta, string tipo, string dono, float saldo = 0, bool status = false)
{
    public int NumeroConta { get; set; } = Numconta;
    protected string TipoConta { get; set; } = tipo;
    private string DonoConta { get; set; } = dono;
    private float SaldoConta { get; set; } = saldo;
    private bool StatusConta { get; set; } = status;

    public void ApresentarDados()
    {
       System.Console.WriteLine($"Numero da conta: {NumeroConta}\nTipo de conta: {TipoConta}\nNome: {DonoConta}\nSaldo: {SaldoConta}\nStatus conta: {StatusConta}");
    }
    public void AlterarTipoConta(string novoTipo)
    {   
        this.TipoConta = novoTipo;
    }
    public void AlterarDono(string novoNome)
    {   
        this.DonoConta = novoNome;
    }
    public void Depositar(float valor)
    {   
        if(StatusConta == false)
        {
            System.Console.WriteLine("Não é possível realizar o deposito, pois a conta está inativa.");
        }
        else
        {
            this.SaldoConta += valor;
        }
    }
    public void Sacar(float valor)
    {   
        if(StatusConta == false)
        {
            Console.Write("Desculpe, mas não é possível realizar o saque em uma conta fechada.");
        }
        else
        {
            if(SaldoConta < valor)
            {
            Console.Write("Saldo solicitado maior que o saldo em conta\nOperação inválida.\n");
            }
            else
            {
                this.SaldoConta -= valor;
            }
        }
    }
    public void AbrirConta(string tipo)
    {   
        if(StatusConta == true){
            System.Console.WriteLine("A conta já está aberta.");
        }
        else
        {
            this.StatusConta =  true;
            System.Console.WriteLine("Conta aberta com sucesso!");
            switch (tipo)
            {
                case "Corrente": 
                    this.TipoConta = "Corrente";
                    this.SaldoConta = 50;
                    break;
                case "Poupanca":
                    this.TipoConta = "Poupanca";
                    this.SaldoConta = 150;
                    break;
                default: 
                    System.Console.WriteLine("Desculpe, mas esta não é uma opção válida.");
                break;
            }
        }
    }
    public void FecharConta()
    {   
        if(SaldoConta >= 0)
        {
            System.Console.WriteLine("Desculpe, mas não é possível realizar o fechamendo da conta.\nÉ necessário que a conta esteja vazia e sem débitos.");
        }
        else
        {
            this.StatusConta = false;
            System.Console.WriteLine("Conta fechada com sucesso!");
        }
    }
    public void PagamentoMensal()
    {
        if(StatusConta == false)
        {
            Console.Write("Desculpe, mas não é possível realizar o pamaento mensal em uma conta inativa.");
        }
        else
        {
            if(TipoConta == "Corrente")
            {
                this.SaldoConta -= 12;
            }
            else
            {
                this.SaldoConta -= 20;
            }
        }
    }
}
