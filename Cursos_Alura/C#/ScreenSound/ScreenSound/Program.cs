using AlbumNamespace;
using BandaNamesPace;
using EpisodioNamespace;
using GeneroNamespace;
using MusicaNamespace;
using PodcastNamespace;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
namespace Porogram
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Banda blackSabbath = new Banda("Black Sabbath");

            Genero heavyMetal = new Genero("Heavy Metal");
            Genero stonerRock = new Genero("Stoner Rock");

            Musica musica1 = new Musica("Paranoid", 148, blackSabbath, heavyMetal);
            Musica musica2 = new Musica("Iron Man", 333, blackSabbath, heavyMetal); 
            Musica musica3 = new Musica("Sweet Leaf", 303, blackSabbath, stonerRock);

            Album paranoid = new Album("Paranoid", musica1, "");
            Album masterOfReality = new Album("Master of Reality", musica2, "");

            blackSabbath.AdicionarAlbum(paranoid);
            blackSabbath.AdicionarAlbum(masterOfReality);

            Console.WriteLine(" Discografia do Black Sabbath:");
            blackSabbath.ExibirDiscografia();

            Console.WriteLine("\n Ficha Técnica das Músicas:");
            musica1.ExibirFichaTecnica(musica1);
            musica2.ExibirFichaTecnica(musica2);
            musica3.ExibirFichaTecnica(musica3);
            */

            Podcast JovemNerd = new Podcast("Lavitan", "NerdCast");
            Episodio FirtEp = new Episodio("Primeiro de muitos!!", 3323, 1);
            Episodio SecondEp = new Episodio("Não deixe ele pegar a granada, se não eu vou chorar!!", 9539, 2);

            JovemNerd.AdicionarEpisodio(FirtEp);
            JovemNerd.AdicionarEpisodio(SecondEp);

            FirtEp.AdicionarConvidados("Cthulhu");
            FirtEp.AdicionarConvidados("Azathoth");
            FirtEp.AdicionarConvidados("Nyarlathotep");
            SecondEp.AdicionarConvidados("Hastur");

            JovemNerd.ExibirDetalhes();

        }
    }
}