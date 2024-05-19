namespace SocialPlatform.Server.Entities.Permissions;

public class ChannelUserPermission
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string ChannelId { get; set; } = string.Empty;
    public Channel? Channel { get; set; }
    
    public string UserId { get; set; } = string.Empty;
    public ApplicationUser? User { get; set; }
    
    public ChannelPermissionType Permissions { get; set; } = ChannelPermissionType.All;
}