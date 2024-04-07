using System.Net.Mime;

namespace SocialPlatform.Core;

[Asset]
public class User
{
    public string UserName { get; set; } = string.Empty;                    // Display Name
    public string Handle { get; set; } = string.Empty;                      // Handle used for tagging and notifications
    public Dictionary<string, string>? RecoveryQa { get; set; }             // Question/Answer pairs for data recovery and Id re-association
    public BitMap? ProfilePicture { get; set; }                             // Profile Picture
    public Role[]? Roles { get; set; }                                       // Permissions for user
    public UserStatus Status { get; set; }                                  // Current Status
    
    public enum UserStatus
    {
        Active,                     // User is online and active
        Inactive,                   // User is online but inactive
        Away,                       // User is offline but their client is still connected in the background
        Offline,                    // User is offline and their client is disconnected
        Invisible,                  // User is online but appears offline
        InGame,                     // User is online and playing a game
        DoNotDisturb                // User's status is unknown and should not be disturbed
    }
    
    public bool HasPermission(Permissions permission)
    {
        if (Roles == null)
            return false;
        
        foreach (var role in Roles)
        {
            if (role.Permissions == null)
                continue;
            
            if (role.Permissions.Contains(permission))
                return true;
        }
        
        return false;
    }
    
    public void AddRole(Role role)
    {
        if (Roles == null)
            Roles = new Role[] { role };
        else
        {
            var roles = new List<Role>(Roles);
            roles.Add(role);
            Roles = roles.ToArray();
        }
    }
    
    public void RemoveRole(Role role)
    {
        if (Roles == null)
            return;
        
        var roles = new List<Role>(Roles);
        roles.Remove(role);
        Roles = roles.ToArray();
    }
}