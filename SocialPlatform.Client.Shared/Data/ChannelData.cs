namespace SocialPlatform.Client.Shared.Data;


public class ChannelData
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public string? ParentId { get; set; }
    public virtual string Type { get; } = "Unknown";
}
    
public class TextChannelData : ChannelData
{
    public const string ChannelType = "Text";
    public List<MessageData> Messages { get; set; } = new();
    public override string Type => ChannelType;
}

public class VoiceChannelData : ChannelData
{
    public const string ChannelType = "Voice";

    public override string Type => ChannelType;
}

public class CategoryChannelData : ChannelData
{
    public const string ChannelType = "Category";

    public override string Type => ChannelType;
}

public class WhiteboardChannelData : ChannelData
{
    public const string ChannelType = "Whiteboard";
    public List<MessageData> Messages { get; set; } = new();

    public override string Type => ChannelType;
}