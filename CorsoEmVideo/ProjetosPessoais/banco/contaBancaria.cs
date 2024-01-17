using System.Buffers;
using System.Reflection.Emit;
using System.Reflection.Metadata;


class ContaBancaria(int Numconta, string tipo, string dono, float saldo, bool status)
{
    public int numeroConta { get; set; } = Numconta;
    protected string tipoConta { get; set; } = tipo;
    private string donoConta { get; set; } = dono;
    private float saldoConta { get; set; } = saldo;
    private bool statusConta { get; set; } = status;

    public void ApresentarDados()
    {
       System.Console.WriteLine($"Numero da conta: {numeroConta}\nTipo de conta: {tipoConta}\nNome: {donoConta}\nSaldo: {saldoConta}\nStatus conta: {statusConta}");
    }
}
