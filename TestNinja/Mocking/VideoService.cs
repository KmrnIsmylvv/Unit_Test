using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace TestNinja.Mocking;

public class VideoService
{
    public string ReadVideoTitle()
    {
        var str = new FileReader().Read("video.txt");
        var video = JsonConvert.DeserializeObject<Video>(str);
        if (video == null)
            return "Error parsing the video.";

        return video.Title;
    }
}

public class Video
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsProcessed { get; set; }
}

public class VideoContext : DbContext
{
    public DbSet<Video> Videos { get; set; }
}