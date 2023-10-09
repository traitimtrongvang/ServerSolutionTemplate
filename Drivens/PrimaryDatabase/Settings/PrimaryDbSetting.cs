namespace PrimaryDatabase.Settings;

public record PrimaryDbSetting
{
    public required string ConnectionStr { get; init; }
}