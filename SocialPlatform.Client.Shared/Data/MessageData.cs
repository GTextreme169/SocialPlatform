namespace SocialPlatform.Client.Shared.Data;

public class MessageData
{
    public string UserId { get; set; }
    public string Content { get; set; }
    public DateTime Time { get; set; }
    
    public MessageData(string userId, string content, DateTime time)
    {
        UserId = userId;
        Content = content;
        Time = time;
    }
    
    public MessageData()
    {
    }
}