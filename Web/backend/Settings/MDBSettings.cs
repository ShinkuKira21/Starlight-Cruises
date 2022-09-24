namespace Server.Settings;

public class MDBSettings
{
    public string User { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Host { get; set; } = string.Empty;

    public string connectionString => $"mongodb://{User}:{Password}@{Host}";
}