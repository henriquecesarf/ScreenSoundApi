using System.Text.Json;

namespace ScreenSoundApi.Models;

internal class FavoriteSongs
{
    public string Name { get; set; }
    public List<Music> FavoriteSongsList;


    public FavoriteSongs (string nome)
    {
        Name = nome;
        FavoriteSongsList = new List<Music>();
    }

    public void AddFavoriteSongs(Music song)
    {
        FavoriteSongsList.Add(song);
    }

    public void ShowFavoriteSongs()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Name}");
        foreach(var song in FavoriteSongsList)
        {
            Console.WriteLine($"-> {song.Name} de {song.Artist}");
        }
        Console.WriteLine();
    }

    public void GenerateJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Name,
            musicas = FavoriteSongsList
        } );
        string fileName = $"musicas-favoritas-{Name}.json";

        File.WriteAllText(fileName, json );

        Console.WriteLine($"Arquivo JSON Criado com sucesso!! {Path.GetFullPath(fileName)}");

    }
}
