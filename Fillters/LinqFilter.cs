using ScreenSoundApi.Models;

namespace ScreenSoundApi.Fillters;

internal class LinqFilter
{
    public static void FilterAllMusicGenders(List<Music> songs)
    {
        var allMusicGenders = songs.Select(genres => genres.Genre).Distinct().ToList();

        foreach (var genre in allMusicGenders)
        {
            Console.WriteLine($"- {genre}");
        }

    }

    public static void FilterArtistByMusicGenre(List<Music> song, string genre)
    {
        var artistByMusicGenre = song.Where(song => song.Genre!.Contains(genre)).Select(song => song.Artist).Distinct().ToList();

        Console.WriteLine($"Exibindo artistas pelo genero musical {genre}:");

        foreach (var artist in artistByMusicGenre)
        {
            Console.WriteLine($"-> {artist}");
        }
    }

    public static void FilterSongsOfArtist(List<Music> songs, string artist)
    {
        var sortedArtistSongs = songs.Where(song => song.Artist!.Equals(artist)).ToList();

        Console.WriteLine($"Exibindo musicas do artista {artist}:");

        foreach(var song in sortedArtistSongs)
        {
            Console.WriteLine($"-> {song.Name}");
        }
    }
}
