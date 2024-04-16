using System.Text.Json.Serialization;

namespace ScreenSoundApi.Models;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }


    private string[] Notes = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };


    public string Note  
    {
        get 
        { 
            return Notes[Key];
        }
    }

    public void ExibirDetalhesDaMuica()
    {
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Nome da música: {Name}");
        Console.WriteLine($"Duração: {Duration / 100 }");
        Console.WriteLine($"Gênero: {Genre}");
        Console.WriteLine($"Tonalidade: {Note}");
    }

}
