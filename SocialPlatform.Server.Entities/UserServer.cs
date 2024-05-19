namespace SocialPlatform.Server.Entities;

public class UserServer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string UserId { get; set; } = string.Empty;
    public ApplicationUser? User { get; set; }
    
    public string ServerId { get; set; } = string.Empty;
    public Server? Server { get; set; }
}