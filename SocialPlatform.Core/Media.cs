namespace SocialPlatform.Core;

[Asset]
public interface Media
{
    public byte[] Data { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}