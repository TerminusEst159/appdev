using Supabase;

public static class SupabaseService
{
    private const string Url = "https://qrgczrnmxmfuenhmzbsb.supabase.co";
    private const string AnonKey = "sb_publishable_xCPSiHzfa0MA3ImofaaA-g_VZUL_QKQ";

    public static Client Client { get; private set; }

    public static async Task InitAsync()
    {
        Client = new Client(Url, AnonKey, new SupabaseOptions { AutoRefreshToken = true });
        await Client.InitializeAsync();
    }
}