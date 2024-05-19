namespace SocialPlatform.Server.Entities;

public class Channel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty; // Icon?
    public string ChannelTopic { get; set; } = string.Empty;
    
    public string? CustomChannelController { get; set; } = null;
    public string? CustomChannelControllerData { get; set; } = null; // JSON
    
    public string ServerId { get; set; } = string.Empty;
    public Server? Server { get; set; }
    
    public List<Message> Messages { get; set; } = new();
}