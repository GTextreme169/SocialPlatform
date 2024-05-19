namespace SocialPlatform.Server.Entities.Permissions;

[Flags]
public enum ChannelPermissionType
{
    All = ~0, // All Permissions
    Read = 1, // Access to the Channel
    Write = 2, // Send Messages
    Reply = 4, // Reply to Messages
    Edit = 8, // Edit Messages (Own)
    Delete = 16, // Delete Messages (Own)
    AttachFiles = 32, // Attach Files
    MentionEveryone = 64, // Mention Everyone
    MentionRoles = 128, // Mention Roles
    MentionUsers = 256, // Mention Users
    React = 512, // React to Messages
    Pin = 1024, // Pin Messages
}