using SocialPlatform.Server.Entities.Permissions;

namespace SocialPlatform.Server.Entities;

public class Role
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    public string ServerId { get; set; } = string.Empty;
    public Server? Server { get; set; }
    
    public List<ApplicationUser> Users { get; set; } = new();
    public List<ChannelRolePermission> ChannelPermissions { get; set; } = new();
}