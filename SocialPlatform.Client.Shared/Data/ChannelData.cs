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
    const string ChannelTypeMessage = "Text";
    public List<MessageData> Messages { get; set; } = new();
    public override string Type => ChannelTypeMessage;
}

public class VoiceChannelData : ChannelData
{
    const string ChannelTypeVoice = "Voice";

    public override string Type => ChannelTypeVoice;
}

public class CategoryChannelData : ChannelData
{
    const string ChannelTypeCategory = "Category";

    public override string Type => ChannelTypeCategory;
}