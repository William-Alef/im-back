interface ILutador
{
    public abstract void Apresentar();
    public abstract void Status();
    public abstract void GanharLuta();
    public abstract void PerderLuta();
    public abstract void EmpatarLuta();
}

interface ILuta
{
    public abstract void MarcarLuta(Lutador lutador1, Lutador lutador2);
    public abstract void Lutar();

}