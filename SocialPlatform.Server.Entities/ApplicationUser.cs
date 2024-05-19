using Microsoft.AspNetCore.Identity;
using SocialPlatform.Server.Entities.Permissions;

namespace SocialPlatform.Server.Entities;

public class ApplicationUser : IdentityUser
{
    public string? DisplayName { get; set; }
    public string? ImageUrl { get; set; }
    public string? Bio { get; set; }
    public string? CustomUserData { get; set; }
    
    public List<ChannelUserPermission> ChannelPermissions { get; set; } = new();
    public List<Role> Roles { get; set; } = new();
    public List<Message> Messages { get; set; } = new();
}