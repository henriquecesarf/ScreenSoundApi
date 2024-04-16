using ScreenSoundApi.Fillters;
using ScreenSoundApi.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var songs =  JsonSerializer.Deserialize<List<Music>>(response);

        //LinqFilter.FilterAllMusicGenders(songs);

        //LinqOrder.ShowSortedArtistList(songs);

        LinqOrder.ShowAllSongsByNote(songs, "C#");


        //LinqFilter.FilterArtistByMusicGenre(songs, "blues");

        //LinqFilter.FilterSongsOfArtist(songs, "The Weeknd");


        //var favoriteSongs1 = new FavoriteSongs("Cesar");
        //favoriteSongs1.AddFavoriteSongs(songs[1943]);
        //favoriteSongs1.AddFavoriteSongs(songs[616]);
        //favoriteSongs1.AddFavoriteSongs(songs[444]);
        //favoriteSongs1.AddFavoriteSongs(songs[12]);
        //favoriteSongs1.AddFavoriteSongs(songs[132]);

        //favoriteSongs1.ShowFavoriteSongs();

        //var FavoriteSongs2 = new FavoriteSongs("Emy");

        //FavoriteSongs2.AddFavoriteSongs(songs[123]);
        //FavoriteSongs2.AddFavoriteSongs(songs[321]);
        //FavoriteSongs2.AddFavoriteSongs(songs[444]);
        //FavoriteSongs2.AddFavoriteSongs(songs[1232]);
        //FavoriteSongs2.AddFavoriteSongs(songs[1993]);

        //FavoriteSongs2.ShowFavoriteSongs();

        //FavoriteSongs2.GenerateJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error:{ex.Message}");
    }


}
