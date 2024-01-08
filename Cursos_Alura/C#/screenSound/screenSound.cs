Musicas musica1 = new Musicas();
    musica1.Nome = "ROBOCOP";
    musica1.Artista = "Sosmula";
    musica1.Duracao = 231;
    musica1.Elegivel = (true);
    Console.WriteLine(musica1.DescricaoResumida);

Musicas musica2 = new Musicas();
    musica2.Nome = "Bohemian Rhapsody";
    musica2.Artista = "Queen";
    musica2.Duracao = 352;
    musica2.Elegivel = (false);

musica1.exibirFixaTecnica();
musica2.exibirFixaTecnica();
