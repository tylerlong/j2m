public partial class AuthzProfile
{
    public string uri;
    public Permission[] permissions;

    public class Permission
    {
        public _Permission permission;
        public EffectiveRole effectiveRole;
        public string[] scopes;

        public class _Permission
        {
            public string uri;
            public string id;
        }

        public class EffectiveRole
        {
            public string uri;
            public string id;
        }
    }
}