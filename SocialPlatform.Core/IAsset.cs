namespace SocialPlatform.Core;

[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface)]
public class AssetAttribute : System.Attribute
{
    public Guid Id { get; set; }
}