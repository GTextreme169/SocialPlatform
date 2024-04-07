namespace SocialPlatform.Core;

public enum Permissions
{
    PostCreate,                     // Create a post of any type
    PostDelete,                     // Delete a post of any type
    PostEdit,                       // Edit a post of any type
    PostView,                       // View a post of any type
    PostMedia,                      // Create, delete, or edit media in a post
    PostReact,                      // React to a post
    PostReport,                     // Report a post
    PostPin,                        // Pin a post
    ChannelCreate,                  // Create a channel
    ChannelDelete,                  // Delete a channel
    ChannelEdit,                    // Edit a channel
    ChannelView,                    // View a channel
    VoiceJoin,                      // Join a voice channel
    VoiceSpeak,                     // Speak in a voice channel
    VoiceMute,                      // Mute a user in a voice channel
    VoiceShowVideo,                 // Show video in a voice channel
    VoiceKick,                      // Kick a user from a voice channel
    ServerEdit,                     // Edit the server
    ServerDelete,                   // Delete the server
    ServerInvite,                   // Invite users to the server
    ServerKick,                     // Kick users from the server
    ServerBan                       // Ban users from the server
}