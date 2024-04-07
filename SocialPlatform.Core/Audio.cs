namespace SocialPlatform.Core;

public class Audio : Media
{
    public byte[] Data { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Encoding { get; set; }
}