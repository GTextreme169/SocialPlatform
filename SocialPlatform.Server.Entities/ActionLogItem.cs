namespace SocialPlatform.Server.Entities;

public class ActionLogItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string UserId { get; set; } = string.Empty;
    public ApplicationUser? User { get; set; }
    
    public string ServerId { get; set; } = string.Empty;
    public Server? Server { get; set; }
    
    public string Action { get; set; } = string.Empty;
    
    public string? PreviousData { get; set; }
    public string? NewData { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}