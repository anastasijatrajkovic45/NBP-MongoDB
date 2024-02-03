namespace TuristickiHub.Models;

public class TuristickiHubDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string AgencijeCollectionName { get; set; }
}