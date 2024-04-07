using System.Drawing;

namespace SocialPlatform.Core;

[Asset]
public class BitMap : Media
{
    public Size ImageSize { get; set; }
    public byte[] Data { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }
    public string Type { get; set; } = string.Empty;
}