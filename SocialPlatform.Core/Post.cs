namespace SocialPlatform.Core;

[Asset]
public class Post
{
    public User Author { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<BitMap>? Images { get; set; }
    public Dictionary<User, Guid>? Reactions { get; set; }
    public Post? ReplyTo { get; set; }
    public List<Post>? Replies { get; set; }
}