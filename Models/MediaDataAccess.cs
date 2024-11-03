using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PP_PO.Models;

public static class MediaDataAccess
{
    private static string filePath = "media.json";

    private static JsonSerializerSettings settings = new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.Auto
    };

    public static void SaveMediaList(List<Media> mediaList)
    {
        string json = JsonConvert.SerializeObject(mediaList, Formatting.Indented, settings);
        File.WriteAllText(filePath, json);
    }

    public static List<Media> LoadMediaList()
    {
        if (!File.Exists(filePath))
        {
            return new List<Media>();
        }
        string json = File.ReadAllText(filePath);
        List<Media> mediaList = JsonConvert.DeserializeObject<List<Media>>(json, settings);
        return mediaList;
    }
}
