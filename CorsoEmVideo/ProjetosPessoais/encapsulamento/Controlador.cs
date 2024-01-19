using System.Dynamic;

public interface IControlador
{
    public abstract void Ligar();
    public abstract void Desligar();
    public abstract void AbrirMenu();
    public abstract void FecharMneu();
    public abstract void AumentarVolume(int volum);
    public abstract void AbaixarVolume(int volum);
    public abstract void AtivarMudo();
    public abstract void DesativarMudo();
    public abstract void Play();
    public abstract void Pause();
}