namespace SocialPlatform.Server.Entities.Permissions;

public class ChannelRolePermission
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string ChannelId { get; set; } = string.Empty;
    public Channel? Channel { get; set; }
    
    public string RoleId { get; set; } = string.Empty;
    public Role? Role { get; set; }
    
    public ChannelPermissionType Permissions { get; set; } = ChannelPermissionType.All;
}