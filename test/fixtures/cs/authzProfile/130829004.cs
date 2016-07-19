public partial class AuthzProfile
{
    public string uri { get; set; }
    public Permission[] permissions { get; set; }

    public class Permission
    {
        public _Permission permission { get; set; }
        public EffectiveRole effectiveRole { get; set; }
        public string[] scopes { get; set; }

        public class _Permission
        {
            public string uri { get; set; }
            public string id { get; set; }
        }

        public class EffectiveRole
        {
            public string uri { get; set; }
            public string id { get; set; }
        }
    }
}