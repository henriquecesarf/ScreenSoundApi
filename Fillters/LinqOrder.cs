using ScreenSoundApi.Models;
using System.Linq;

namespace ScreenSoundApi.Fillters;

internal class LinqOrder
{
    public static void ShowSortedArtistList(List<Music> songs)
    {
        var SortedArtist = songs.OrderBy(song => song.Artist).Select(song => song.Artist).Distinct().ToList();

        Console.WriteLine("Lista de artistas Ordenados:");

        foreach (var artist in SortedArtist)
        {
            Console.WriteLine($"-> {artist}");
        }
    }

    public static void ShowAllSongsByNote(List<Music> songs, string songIndex)
    {
        var SongsByNote = songs.Where(song => song.Note.Equals(songIndex)).Select(song => song.Name).Distinct().ToList();

        Console.WriteLine($"Lista de músicas pela nota {songIndex}:");

        foreach (var song in SongsByNote)
        {
            Console.WriteLine($"-> {song}");
        };
    }
}
