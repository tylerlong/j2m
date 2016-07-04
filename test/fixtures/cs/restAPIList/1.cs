public partial class RestApiList
{
    public string uri;
    public ApiVersion[] apiVersions;
    public string serverVersion;
    public string serverRevision;

    public class ApiVersion
    {
        public string uri;
        public string versionString;
        public string releaseDate;
        public string uriString;
    }
}