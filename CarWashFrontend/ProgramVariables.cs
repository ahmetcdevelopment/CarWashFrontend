namespace CarWashFrontend;

public static class ProgramVariables
{
    public static string APICONNECTION { get; set; }
    static ProgramVariables()
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        APICONNECTION = configuration["APICONNECTION"];
    }
}
