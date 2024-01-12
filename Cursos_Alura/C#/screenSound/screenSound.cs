Album AlbumDoQueen = new Album();
AlbumDoQueen.Nome = "A nogth at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

AlbumDoQueen.AdicionarMusica(musica1);
AlbumDoQueen.AdicionarMusica(musica2);

Banda queen = new Banda();
queen.Nome = "Queen";
queen.adicionarAlbum(AlbumDoQueen);
queen.exibirDiscografia();