namespace SocialPlatform.Core;

[Asset]
public class Channel
{
    public string Title { get; set; } = string.Empty;
    public ChannelContentAttribute? Content { get; set; }
    public List<User>? Users { get; set; }
    public Permissions? ChannelPermissions { get; set; }
    public List<Channel>? SubChannels { get; set; }
}