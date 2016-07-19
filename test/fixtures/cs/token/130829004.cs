public partial class Token
{
    public string access_token { get; set; }
    public string token_type { get; set; }
    public int? expires_in { get; set; }
    public string refresh_token { get; set; }
    public int? refresh_token_expires_in { get; set; }
    public string scope { get; set; }
    public string owner_id { get; set; }
    public string endpoint_id { get; set; }
}