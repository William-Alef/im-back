namespace Alura.Filmes;

public class Program
{
    static void Main(string[] args)
    {

        Artista ellenBurstyn = new("Ellen Burstyn", 41);
        Artista lindaBlair = new("Linda Blair", 14);
        Artista maxVonSydow = new("Max von Sydow", 44);
        Artista jasonMiller = new("Jason Miller", 34);
        Artista leeJCobb = new("Lee J. Cobb", 62);

        Artista heatherLangenkamp = new("Heather Langenkamp", 20);
        Artista robertEnglund = new("Robert Englund", 37);
        Artista johnnyDepp = new("Johnny Depp", 21);
        Artista johnSaxon = new("John Saxon", 48);
        Artista roneeBlakley = new("Ronee Blakley", 38);

        Artista patrickWilson = new("Patrick Wilson", 40);
        Artista veraFarmiga = new("Vera Farmiga", 39);
        Artista ronLivingston = new("Ron Livingston", 45);
        Artista liliTaylor = new("Lili Taylor", 46);
        Artista shanleyCaswell = new("Shanley Caswell", 21);

        Artista toniCollette = new("Toni Collette", 45);
        Artista alexWolff = new("Alex Wolff", 20);
        Artista millyShapiro = new("Milly Shapiro", 15);
        Artista gabrielByrne = new("Gabriel Byrne", 68);
        Artista annDowd = new("Ann Dowd", 62);

        Artista jaedenMartell = new("Jaeden Martell", 14);
        Artista finnWolfhard = new("Finn Wolfhard", 14);
        Artista sophiaLillis = new("Sophia Lillis", 15);
        Artista billSkarsgard = new("Bill Skarsgård", 27);
        Artista jackDylanGrazer = new("Jack Dylan Grazer", 14);

        List<Artista> elencoExorcist = new() { ellenBurstyn, lindaBlair, maxVonSydow, jasonMiller, leeJCobb };
        List<Artista> elencoElmStreet = new() { heatherLangenkamp, robertEnglund, johnnyDepp, johnSaxon, roneeBlakley };
        List<Artista> elencoConjuring = new() { patrickWilson, veraFarmiga, ronLivingston, liliTaylor, shanleyCaswell };
        List<Artista> elencoHereditary = new() { toniCollette, alexWolff, millyShapiro, gabrielByrne, annDowd };
        List<Artista> elencoIt = new() { jaedenMartell, finnWolfhard, sophiaLillis, billSkarsgard, jackDylanGrazer };

        Filme theExorcist = new("The Exorcist", 7280, elencoExorcist);
        Filme aNightmareOnElmStreet = new("A Nightmare on Elm Street", 6060, elencoElmStreet);
        Filme theConjuring = new("The Conjuring", 6720, elencoConjuring);
        Filme hereditary = new("Hereditary", 7620, elencoHereditary);
        Filme it = new("It", 8100, elencoIt);

        it.ApresentarFilme();
    }

}