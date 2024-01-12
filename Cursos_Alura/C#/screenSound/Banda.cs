class Banda
{
    private List<Album> albums = new List<Album>();
    public string Nome {get; set;}

    public void adicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void exibirDiscografia(){
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome}");
        }
    }

}