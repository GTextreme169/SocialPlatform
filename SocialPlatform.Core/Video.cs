namespace SocialPlatform.Core;

public class Video : Media
{
    public byte[] Data { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public BitMap[] Frames { get; set; }
    public string Encoding { get; set; } = string.Empty;
    public Audio? Audio { get; set; }
}