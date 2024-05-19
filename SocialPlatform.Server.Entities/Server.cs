using SocialPlatform.Server.Entities.Permissions;

namespace SocialPlatform.Server.Entities;

public class Server
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public List<Channel> Channels { get; set; } = new();
    public List<Role> Roles { get; set; } = new();
    public List<ApplicationUser> Users { get; set; } = new();
    public List<ActionLogItem> ActionLog { get; set; } = new();
    
    public List<ChannelUserPermission> ChannelUserPermissions { get; set; } = new();
    public List<ChannelRolePermission> ChannelRolePermissions { get; set; } = new();
    
    public bool IsPublic { get; set; } = false;
}