using SocialPlatform.Client.Shared.Data;

namespace SocialPlatform.Client.Shared.Services;

// Manages the connection to the server And Data Caching
public class ServerService
{
    private class ServerData
    {
        public int _id;
        public string ServerAddress { get; set; }
        public string ServerName { get; set; }
        public string ServerIcon { get; set; }
        public long LastServerPing { get; set; }
        
        public List<UserData> Users { get; private set; } = new();
    
        public List<ChannelData> Channels { get; private set; } = new();
    }
    
    private readonly List<ServerData> _servers = new();
    
    public int? CurrentServerId { get; private set; }
    private ServerData? CurrentServer => _servers.FirstOrDefault(s => s._id == CurrentServerId);
    
    public List<UserData> Users => CurrentServer?.Users ?? new();
    public List<ChannelData> Channels => CurrentServer?.Channels ?? new();
    
    
    private int nextId = 1;
    public void Connect()
    {
        // Connect to the server
        // Fetch all users
        // Fetch all channels
        
        // Make Fake Data
        // TODO: Remove this
        
        var serverData = new ServerData
        {
            _id = nextId,
            ServerAddress = "0.0.0.0:8080",
            ServerName = "Test Server",
            ServerIcon = "https://via.placeholder.com/150",
            LastServerPing = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
        };
        nextId++;
        
        serverData.Users.Add(new UserData
        {
            Id = "1",
            Username = "User1",
            StatusMessage = "Hello World"
        });
        
        
        var generalText = new TextChannelData
        {
            Name = "General",
            Id = "1"
        };
        generalText.Messages.Add(new MessageData("1", "Test", DateTime.Now));
        
        var whiteboard = new WhiteboardChannelData
        {
            Name = "Whiteboard",
            Id = "200"
        };
        
        
        var category1 = new CategoryChannelData
        {
            Name = "Voice Channels",
            Id = "2"
        };

        var voice1 = new VoiceChannelData
        {
            Name = "General Voice",
            Id = "3",
            ParentId = "2",
            Description = "This is the general voice channel"
        };

        var voice2 = new VoiceChannelData
        {
            Name = "AFK",
            Id = "4",
            ParentId = "2",
            Description = "This is the AFK channel"
        };

        serverData.Channels.Add(generalText);
        serverData.Channels.Add(whiteboard);
        serverData.Channels.Add(category1);
        serverData.Channels.Add(voice1);
        serverData.Channels.Add(voice2);


        _servers.Add(serverData);
        CurrentServerId = serverData._id;
    }
}