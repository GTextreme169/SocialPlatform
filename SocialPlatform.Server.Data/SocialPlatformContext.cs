using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialPlatform.Server.Entities;
using SocialPlatform.Server.Entities.Permissions;

namespace SocialPlatform.Server.Data;

public class SocialPlatformContext : IdentityDbContext<ApplicationUser>
{
    // Entities
    public DbSet<Entities.Server> Servers => Set<Entities.Server>();
        public DbSet<Channel> Channels => Set<Channel>();
            public DbSet<Message> Messages => Set<Message>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<ActionLogItem> ActionLog => Set<ActionLogItem>();
    
    // Pivot Entities
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<UserServer> UserServers => Set<UserServer>();
    
    // Permissions
    public DbSet<ChannelUserPermission> ChannelUserPermissions => Set<ChannelUserPermission>();
    public DbSet<ChannelRolePermission> ChannelRolePermissions => Set<ChannelRolePermission>();
}