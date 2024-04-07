namespace SocialPlatform.Core;

[Asset]
public class Role
{
    public string Name { get; set; } = string.Empty;
    public Permissions[]? Permissions { get; set; }
}