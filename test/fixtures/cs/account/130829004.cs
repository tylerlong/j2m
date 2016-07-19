public partial class Account
{
    public string uri { get; set; }
    public int? id { get; set; }
    public ServiceInfo serviceInfo { get; set; }
    public Operator @operator { get; set; }
    public string mainNumber { get; set; }
    public string status { get; set; }
    public SignupInfo signupInfo { get; set; }
    public string setupWizardState { get; set; }

    public class ServiceInfo
    {
        public string uri { get; set; }
        public Brand brand { get; set; }
        public ServicePlan servicePlan { get; set; }
        public BillingPlan billingPlan { get; set; }

        public class Brand
        {
            public string id { get; set; }
            public string name { get; set; }
            public HomeCountry homeCountry { get; set; }

            public class HomeCountry
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string name { get; set; }
                public string isoCode { get; set; }
                public string callingCode { get; set; }
            }
        }

        public class ServicePlan
        {
            public string id { get; set; }
            public string name { get; set; }
            public string edition { get; set; }
        }

        public class BillingPlan
        {
            public string id { get; set; }
            public string name { get; set; }
            public string durationUnit { get; set; }
            public int? duration { get; set; }
            public string type { get; set; }
        }
    }

    public class Operator
    {
        public string uri { get; set; }
        public int? id { get; set; }
        public string extensionNumber { get; set; }
    }

    public class SignupInfo
    {
    }
}