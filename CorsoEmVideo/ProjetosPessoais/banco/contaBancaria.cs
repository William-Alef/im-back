using System.Buffers;
using System.Reflection.Emit;
using System.Reflection.Metadata;


class ContaBancaria(int Numconta, string tipo, string dono, float saldo, bool status)
{
    public int numeroConta = Numconta;
    protected string tipoConta = tipo;
    private string donoConta = dono;
    private float saldoConta = saldo;
    private bool statusConta = status;

    public string GetDono()
    {
        return this.donoConta;
    }
    public void SetDono(string dc)
    {
        this.donoConta = dc;
    }
    public float GetSaldo()
    {
        return this.saldoConta;
    }
    public void SetSaldo(float s)
    {
        this.saldoConta = s;
    }
    public int GetNumeroConta()
    {
        return this.numeroConta;
    }
    public void SetNumeroConta(int nc)
    {
        this.numeroConta = nc;
    }
    public string GetTipoConta()
    {
        return this.tipoConta;
    }
    public void SetTipoConta(string tc)
    {
        this.tipoConta = tc;
    }
    public bool GetStatusConta()
    {
        return this.statusConta;
    }
    public void SetStatusConta(bool sc)
    {
        this.statusConta = sc;
    }
    public void ApresentarDados()
    {
       System.Console.WriteLine($"Numero da conta: {GetNumeroConta()}\nTipo de conta: {GetTipoConta()}\nNome: {GetDono()}\nSaldo: {GetSaldo()}\nStatus conta: {GetStatusConta()}");
    }
}
