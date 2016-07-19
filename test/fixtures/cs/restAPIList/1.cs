public partial class RestApiList
{
    public string uri { get; set; }
    public ApiVersion[] apiVersions { get; set; }
    public string serverVersion { get; set; }
    public string serverRevision { get; set; }

    public class ApiVersion
    {
        public string uri { get; set; }
        public string versionString { get; set; }
        public string releaseDate { get; set; }
        public string uriString { get; set; }
    }
}