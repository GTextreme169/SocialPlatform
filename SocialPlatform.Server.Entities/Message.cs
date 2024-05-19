namespace SocialPlatform.Server.Entities;

public class Message
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string ChannelId { get; set; } = string.Empty;
    public Channel? Channel { get; set; }
    
    public string UserId { get; set; } = string.Empty;
    public ApplicationUser? User { get; set; }
    
    public string Content { get; set; } = string.Empty; // Could Be Plain Text, Markdown, HTML, etc. (Handled by the Channel Controller)
}