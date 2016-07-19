public partial class Swagger
{
    public string swagger { get; set; }
    public Info info { get; set; }
    public string host { get; set; }
    public string basePath { get; set; }
    public string[] schemes { get; set; }
    public string[] produces { get; set; }
    public string[] consumes { get; set; }
    public SecurityDefinitions securityDefinitions { get; set; }
    public Security[] security { get; set; }
    public Parameters parameters { get; set; }
    public Definitions definitions { get; set; }
    public Paths paths { get; set; }

    public class Info
    {
        public string version { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string termsOfService { get; set; }
    }

    public class SecurityDefinitions
    {
        public Oauth oauth { get; set; }

        public class Oauth
        {
            public string type { get; set; }
            public string flow { get; set; }
            public string authorizationUrl { get; set; }
            public string tokenUrl { get; set; }
            public Scopes scopes { get; set; }

            public class Scopes
            {
                public string @default { get; set; }
            }
        }
    }

    public class Security
    {
        public string[] oauth { get; set; }
    }

    public class Parameters
    {
        public AccountId accountId { get; set; }
        public AnsweringRuleId answeringRuleId { get; set; }
        public AttachmentId attachmentId { get; set; }
        public BlockedNumberId blockedNumberId { get; set; }
        public BrandId brandId { get; set; }
        public CallLogId callLogId { get; set; }
        public CompanyPagerId companyPagerId { get; set; }
        public ContactId contactId { get; set; }
        public CountryId countryId { get; set; }
        public CustomDataKey customDataKey { get; set; }
        public DepartmentId departmentId { get; set; }
        public DeviceId deviceId { get; set; }
        public ExtensionId extensionId { get; set; }
        public FaxId faxId { get; set; }
        public GroupId groupId { get; set; }
        public LanguageId languageId { get; set; }
        public LineId lineId { get; set; }
        public MessageId messageId { get; set; }
        public OrderId orderId { get; set; }
        public PhoneNumberId phoneNumberId { get; set; }
        public RecordingId recordingId { get; set; }
        public RingoutId ringoutId { get; set; }
        public ScaleSize scaleSize { get; set; }
        public SecretQuestionId secretQuestionId { get; set; }
        public ServicePlanId servicePlanId { get; set; }
        public SmsId smsId { get; set; }
        public StateId stateId { get; set; }
        public SubscriptionId subscriptionId { get; set; }
        public TimezoneId timezoneId { get; set; }
        public UserGroupId userGroupId { get; set; }
        public VerificationCallId verificationCallId { get; set; }

        public class AccountId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
            public string @default { get; set; }
        }

        public class AnsweringRuleId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class AttachmentId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class BlockedNumberId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class BrandId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class CallLogId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class CompanyPagerId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class ContactId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class CountryId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class CustomDataKey
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class DepartmentId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class DeviceId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class ExtensionId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
            public string @default { get; set; }
        }

        public class FaxId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class GroupId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class LanguageId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class LineId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class MessageId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class OrderId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class PhoneNumberId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class RecordingId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class RingoutId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class ScaleSize
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
            public string[] @enum { get; set; }
        }

        public class SecretQuestionId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class ServicePlanId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class SmsId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class StateId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class SubscriptionId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class TimezoneId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class UserGroupId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }

        public class VerificationCallId
        {
            public string name { get; set; }
            public string @in { get; set; }
            public bool? required { get; set; }
            public string type { get; set; }
            public string description { get; set; }
        }
    }

    public class Definitions
    {
        public AccountInfo AccountInfo { get; set; }
        public AccountLimits AccountLimits { get; set; }
        public AddonInfo AddonInfo { get; set; }
        public AnsweringRuleInfo AnsweringRuleInfo { get; set; }
        public AnsweringRuleInfoCalleeInfo AnsweringRuleInfo.CalleeInfo { get; set; }
        public AnsweringRuleInfoCallerInfo AnsweringRuleInfo.CallerInfo { get; set; }
        public AttachmentInfo AttachmentInfo { get; set; }
        public BillingPlanInfo BillingPlanInfo { get; set; }
        public BlockedNumberInfo BlockedNumberInfo { get; set; }
        public BrandInfo BrandInfo { get; set; }
        public BusinessAddressInfo BusinessAddressInfo { get; set; }
        public BusinessHourScheduleInfo BusinessHour.ScheduleInfo { get; set; }
        public CallLogInfo CallLogInfo { get; set; }
        public CallLogRecord CallLogRecord { get; set; }
        public CallerInfo CallerInfo { get; set; }
        public ConferencingRequestPhoneNumber Conferencing.Request.PhoneNumber { get; set; }
        public ConferencingInfo ConferencingInfo { get; set; }
        public ConferencingInfoPhoneNumberInfo ConferencingInfo.PhoneNumberInfo { get; set; }
        public ConferencingInfoPhoneNumberInfoCountryInfo ConferencingInfo.PhoneNumberInfo.CountryInfo { get; set; }
        public ContactAddressInfo ContactAddressInfo { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public CountryInfo CountryInfo { get; set; }
        public DeliveryMode DeliveryMode { get; set; }
        public DepartmentResponseExtensionInfo Department.Response.ExtensionInfo { get; set; }
        public DepartmentInfo DepartmentInfo { get; set; }
        public DeviceInfo DeviceInfo { get; set; }
        public DeviceInfoExtensionInfo DeviceInfo.ExtensionInfo { get; set; }
        public EmergencyAddressInfo EmergencyAddressInfo { get; set; }
        public ExtensionInfo ExtensionInfo { get; set; }
        public ExtensionInfoRequestContactInfo ExtensionInfo.Request.ContactInfo { get; set; }
        public ExtensionInfoRequestContactInfoRegionalSettings ExtensionInfo.Request.ContactInfo.RegionalSettings { get; set; }
        public ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale ExtensionInfo.Request.ContactInfo.RegionalSettings.FormattingLocale { get; set; }
        public ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage ExtensionInfo.Request.ContactInfo.RegionalSettings.GreetingLanguage { get; set; }
        public ExtensionInfoRequestContactInfoRegionalSettingsLanguage ExtensionInfo.Request.ContactInfo.RegionalSettings.Language { get; set; }
        public ExtensionInfoRequestContactInfoRegionalSettingsTimezone ExtensionInfo.Request.ContactInfo.RegionalSettings.Timezone { get; set; }
        public ExtensionInfoRequestPartnerId ExtensionInfo.Request.PartnerId { get; set; }
        public ExtensionInfoRequestPasswordPin ExtensionInfo.Request.PasswordPIN { get; set; }
        public ExtensionInfoRequestProvision ExtensionInfo.Request.Provision { get; set; }
        public ExtensionInfoRequestProvisionContactInfo ExtensionInfo.Request.Provision.ContactInfo { get; set; }
        public ExtensionInfoRequestStatusInfo ExtensionInfo.Request.StatusInfo { get; set; }
        public ExtensionPermissions ExtensionPermissions { get; set; }
        public ExtensionServiceFeatureInfo ExtensionServiceFeatureInfo { get; set; }
        public FormattingLocaleInfo FormattingLocaleInfo { get; set; }
        public ForwardingInfo ForwardingInfo { get; set; }
        public ForwardingNumberInfo ForwardingNumberInfo { get; set; }
        public FullCountryInfo FullCountryInfo { get; set; }
        public GrantInfo GrantInfo { get; set; }
        public GrantInfoExtensionInfo GrantInfo.ExtensionInfo { get; set; }
        public GreetingLanguageInfo GreetingLanguageInfo { get; set; }
        public GroupInfo GroupInfo { get; set; }
        public LanguageInfo LanguageInfo { get; set; }
        public LegInfo LegInfo { get; set; }
        public LegInfoExtensionInfo LegInfo.ExtensionInfo { get; set; }
        public LinksInfo LinksInfo { get; set; }
        public LocationInfo LocationInfo { get; set; }
        public LookUpPhoneNumberPhoneNumberInfo LookUpPhoneNumber.PhoneNumberInfo { get; set; }
        public MeetingInfo MeetingInfo { get; set; }
        public MeetingScheduleInfo MeetingScheduleInfo { get; set; }
        public MeetingScheduleInfoTimezoneInfo MeetingScheduleInfo.TimezoneInfo { get; set; }
        public MessageAttachmentInfo MessageAttachmentInfo { get; set; }
        public MessageInfo MessageInfo { get; set; }
        public MessageInfoCallerInfo MessageInfo.CallerInfo { get; set; }
        public ModelInfo ModelInfo { get; set; }
        public NavigationInfo NavigationInfo { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public ParsePhoneNumberCountryInfo ParsePhoneNumber.CountryInfo { get; set; }
        public ParsePhoneNumberPhoneNumberInfo ParsePhoneNumber.PhoneNumberInfo { get; set; }
        public PermissionInfo PermissionInfo { get; set; }
        public PersonalContactInfo PersonalContactInfo { get; set; }
        public PhoneLinesInfo PhoneLinesInfo { get; set; }
        public PhoneLinesInfoPhoneNumberInfo PhoneLinesInfo.PhoneNumberInfo { get; set; }
        public PhoneNumberInfo PhoneNumberInfo { get; set; }
        public PhoneNumberInfoExtensionInfo PhoneNumberInfo.ExtensionInfo { get; set; }
        public PresenceInfo PresenceInfo { get; set; }
        public PresenceInfoExtensionInfo PresenceInfo.ExtensionInfo { get; set; }
        public ProfileImageInfo ProfileImageInfo { get; set; }
        public RangesInfo RangesInfo { get; set; }
        public RecipientInfo RecipientInfo { get; set; }
        public RecordingInfo RecordingInfo { get; set; }
        public ReferenceInfo ReferenceInfo { get; set; }
        public RegionalSettings RegionalSettings { get; set; }
        public ReservePhoneNumberRequestReserveRecord ReservePhoneNumber.Request.ReserveRecord { get; set; }
        public ReservePhoneNumberResponseReserveRecord ReservePhoneNumber.Response.ReserveRecord { get; set; }
        public RingOutRequestCountryInfo RingOut.Request.CountryInfo { get; set; }
        public RingOutRequestFrom RingOut.Request.From { get; set; }
        public RingOutRequestTo RingOut.Request.To { get; set; }
        public RingOutInfo RingOutInfo { get; set; }
        public RingOutStatusInfo RingOutStatusInfo { get; set; }
        public RuleInfo RuleInfo { get; set; }
        public RuleInfoForwardingNumberInfo RuleInfo.ForwardingNumberInfo { get; set; }
        public ScheduleInfo ScheduleInfo { get; set; }
        public ServerInfo ServerInfo { get; set; }
        public ServiceFeatureInfo ServiceFeatureInfo { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
        public ServicePlanInfo ServicePlanInfo { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public ShippingInfo ShippingInfo { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public StateInfo StateInfo { get; set; }
        public StateInfoCountryInfo StateInfo.CountryInfo { get; set; }
        public StatusInfo StatusInfo { get; set; }
        public SubscriptionRequestDeliveryMode Subscription.Request.DeliveryMode { get; set; }
        public SubscriptionInfo SubscriptionInfo { get; set; }
        public SyncInfo SyncInfo { get; set; }
        public TargetServicePlanInfo TargetServicePlanInfo { get; set; }
        public TimeInterval TimeInterval { get; set; }
        public TimezoneInfo TimezoneInfo { get; set; }
        public UnconditionalForwardingInfo UnconditionalForwardingInfo { get; set; }
        public VersionInfo VersionInfo { get; set; }
        public VoicemailInfo VoicemailInfo { get; set; }
        public WeeklyScheduleInfo WeeklyScheduleInfo { get; set; }

        public class AccountInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public MainNumber mainNumber { get; set; }
                public Operator @operator { get; set; }
                public PartnerId partnerId { get; set; }
                public ServiceInfo serviceInfo { get; set; }
                public SetupWizardState setupWizardState { get; set; }
                public Status status { get; set; }
                public StatusInfo statusInfo { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class MainNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Operator
                {
                    public string @ref { get; set; }
                }

                public class PartnerId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ServiceInfo
                {
                    public string @ref { get; set; }
                }

                public class SetupWizardState
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class StatusInfo
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class AccountLimits
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public FreeSoftPhoneLinesPerExtension freeSoftPhoneLinesPerExtension { get; set; }
                public MeetingSize meetingSize { get; set; }
                public MaxMonitoredExtensionsPerUser maxMonitoredExtensionsPerUser { get; set; }

                public class FreeSoftPhoneLinesPerExtension
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class MeetingSize
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class MaxMonitoredExtensionsPerUser
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class AddonInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Count count { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Count
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class AnsweringRuleInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public Id id { get; set; }
                public Type type { get; set; }
                public Name name { get; set; }
                public Enabled enabled { get; set; }
                public Schedule schedule { get; set; }
                public CalledNumbers calledNumbers { get; set; }
                public Callers callers { get; set; }
                public CallHandlingAction callHandlingAction { get; set; }
                public Forwarding forwarding { get; set; }
                public UnconditionalForwarding unconditionalForwarding { get; set; }
                public Voicemail voicemail { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Enabled
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Schedule
                {
                    public string @ref { get; set; }
                }

                public class CalledNumbers
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Callers
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class CallHandlingAction
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Forwarding
                {
                    public string @ref { get; set; }
                }

                public class UnconditionalForwarding
                {
                    public string @ref { get; set; }
                }

                public class Voicemail
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class AnsweringRuleInfoCalleeInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class AnsweringRuleInfoCallerInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public CallerId callerId { get; set; }
                public Name name { get; set; }

                public class CallerId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class AttachmentInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public ContentType contentType { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ContentType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class BillingPlanInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Name name { get; set; }
                public DurationUnit durationUnit { get; set; }
                public Duration duration { get; set; }
                public Type type { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class DurationUnit
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Duration
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class BlockedNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Name name { get; set; }
                public PhoneNumber phoneNumber { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class BrandInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Name name { get; set; }
                public HomeCountry homeCountry { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class HomeCountry
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class BusinessAddressInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Country country { get; set; }
                public State state { get; set; }
                public City city { get; set; }
                public Street street { get; set; }
                public Zip zip { get; set; }

                public class Country
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class State
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class City
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Street
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Zip
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class BusinessHourScheduleInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public WeeklyRanges weeklyRanges { get; set; }

                public class WeeklyRanges
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class CallLogInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public SessionId sessionId { get; set; }
                public From from { get; set; }
                public To to { get; set; }
                public Type type { get; set; }
                public Direction direction { get; set; }
                public Action action { get; set; }
                public Result result { get; set; }
                public StartTime startTime { get; set; }
                public Duration duration { get; set; }
                public Recording recording { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class SessionId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class From
                {
                    public string @ref { get; set; }
                }

                public class To
                {
                    public string @ref { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Direction
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Action
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Result
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class StartTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class Duration
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Recording
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class CallLogRecord
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public SessionId sessionId { get; set; }
                public From from { get; set; }
                public To to { get; set; }
                public Type type { get; set; }
                public Direction direction { get; set; }
                public Action action { get; set; }
                public Result result { get; set; }
                public StartTime startTime { get; set; }
                public Duration duration { get; set; }
                public Recording recording { get; set; }
                public LastModifiedTime lastModifiedTime { get; set; }
                public Transport transport { get; set; }
                public Legs legs { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class SessionId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class From
                {
                    public string @ref { get; set; }
                }

                public class To
                {
                    public string @ref { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Direction
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Action
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Result
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class StartTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class Duration
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Recording
                {
                    public string @ref { get; set; }
                }

                public class LastModifiedTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class Transport
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Legs
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }
            }
        }

        public class CallerInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }
                public ExtensionNumber extensionNumber { get; set; }
                public Location location { get; set; }
                public Name name { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Location
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ConferencingRequestPhoneNumber
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }
                public Default @default { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Default
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ConferencingInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public AllowJoinBeforeHost allowJoinBeforeHost { get; set; }
                public HostCode hostCode { get; set; }
                public Mode mode { get; set; }
                public ParticipantCode participantCode { get; set; }
                public PhoneNumber phoneNumber { get; set; }
                public TapToJoinUri tapToJoinUri { get; set; }
                public PhoneNumbers phoneNumbers { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class AllowJoinBeforeHost
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class HostCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Mode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ParticipantCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class TapToJoinUri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PhoneNumbers
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }
            }
        }

        public class ConferencingInfoPhoneNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Country country { get; set; }
                public Default @default { get; set; }
                public HasGreeting hasGreeting { get; set; }
                public Location location { get; set; }
                public PhoneNumber phoneNumber { get; set; }

                public class Country
                {
                    public string @ref { get; set; }
                }

                public class Default
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class HasGreeting
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Location
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ConferencingInfoPhoneNumberInfoCountryInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public CallingCode callingCode { get; set; }
                public EmergencyCalling emergencyCalling { get; set; }
                public IsoCode isoCode { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class CallingCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class EmergencyCalling
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class IsoCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ContactAddressInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Country country { get; set; }
                public State state { get; set; }
                public City city { get; set; }
                public Street street { get; set; }
                public Zip zip { get; set; }

                public class Country
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class State
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class City
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Street
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Zip
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ContactInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public FirstName firstName { get; set; }
                public LastName lastName { get; set; }
                public Company company { get; set; }
                public Email email { get; set; }
                public BusinessPhone businessPhone { get; set; }
                public BusinessAddress businessAddress { get; set; }

                public class FirstName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LastName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Company
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Email
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class BusinessPhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class BusinessAddress
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class CountryInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class DeliveryMode
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public TransportType transportType { get; set; }
                public Encryption encryption { get; set; }
                public Address address { get; set; }
                public SubscriberKey subscriberKey { get; set; }
                public SecretKey secretKey { get; set; }
                public EncryptionAlgorithm encryptionAlgorithm { get; set; }
                public EncryptionKey encryptionKey { get; set; }

                public class TransportType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Encryption
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Address
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class SubscriberKey
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class SecretKey
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class EncryptionAlgorithm
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class EncryptionKey
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class DepartmentResponseExtensionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public ExtensionNumber extensionNumber { get; set; }
                public PartnerId partnerId { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PartnerId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class DepartmentInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public ExtensionNumber extensionNumber { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class DeviceInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Sku sku { get; set; }
                public Type type { get; set; }
                public Name name { get; set; }
                public Serial serial { get; set; }
                public ComputerName computerName { get; set; }
                public Model model { get; set; }
                public Extension extension { get; set; }
                public EmergencyServiceAddress emergencyServiceAddress { get; set; }
                public PhoneLines phoneLines { get; set; }
                public Shipping shipping { get; set; }
                public BoxBillingId boxBillingId { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Sku
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Serial
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ComputerName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Model
                {
                    public string @ref { get; set; }
                }

                public class Extension
                {
                    public string @ref { get; set; }
                }

                public class EmergencyServiceAddress
                {
                    public string @ref { get; set; }
                }

                public class PhoneLines
                {
                    public string @ref { get; set; }
                }

                public class Shipping
                {
                    public string @ref { get; set; }
                }

                public class BoxBillingId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class DeviceInfoExtensionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public ExtensionNumber extensionNumber { get; set; }
                public PartnerId partnerId { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PartnerId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class EmergencyAddressInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public CustomerName customerName { get; set; }
                public Street street { get; set; }
                public Street2 street2 { get; set; }
                public City city { get; set; }
                public State state { get; set; }
                public Zip zip { get; set; }
                public Country country { get; set; }

                public class CustomerName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Street
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Street2
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class City
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class State
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Zip
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Country
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Contact contact { get; set; }
                public Departments departments { get; set; }
                public ExtensionNumber extensionNumber { get; set; }
                public Name name { get; set; }
                public PartnerId partnerId { get; set; }
                public Permissions permissions { get; set; }
                public ProfileImage profileImage { get; set; }
                public References references { get; set; }
                public RegionalSettings regionalSettings { get; set; }
                public ServiceFeatures serviceFeatures { get; set; }
                public SetupWizardState setupWizardState { get; set; }
                public Status status { get; set; }
                public StatusInfo statusInfo { get; set; }
                public Type type { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Contact
                {
                    public string @ref { get; set; }
                }

                public class Departments
                {
                    public string @ref { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PartnerId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Permissions
                {
                    public string @ref { get; set; }
                }

                public class ProfileImage
                {
                    public string @ref { get; set; }
                }

                public class References
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class RegionalSettings
                {
                    public string @ref { get; set; }
                }

                public class ServiceFeatures
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class SetupWizardState
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class StatusInfo
                {
                    public string @ref { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestContactInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Contact contact { get; set; }
                public RegionalSettings regionalSettings { get; set; }
                public SetupWizardState setupWizardState { get; set; }
                public Department department { get; set; }

                public class Contact
                {
                    public string @ref { get; set; }
                }

                public class RegionalSettings
                {
                    public string @ref { get; set; }
                }

                public class SetupWizardState
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Department
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettings
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Timezone timezone { get; set; }
                public Language language { get; set; }
                public GreetingLanguage greetingLanguage { get; set; }
                public FormattingLocale formattingLocale { get; set; }

                public class Timezone
                {
                    public string @ref { get; set; }
                }

                public class Language
                {
                    public string @ref { get; set; }
                }

                public class GreetingLanguage
                {
                    public string @ref { get; set; }
                }

                public class FormattingLocale
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsLanguage
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsTimezone
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestPartnerId
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PartnerId partnerId { get; set; }

                public class PartnerId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestPasswordPin
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Password password { get; set; }
                public IvrPin ivrPin { get; set; }

                public class Password
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class IvrPin
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestProvision
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Status status { get; set; }
                public Contact contact { get; set; }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Contact
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestProvisionContactInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public FirstName firstName { get; set; }
                public LastName lastName { get; set; }
                public Email email { get; set; }

                public class FirstName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LastName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Email
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ExtensionInfoRequestStatusInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Status status { get; set; }
                public StatusInfo statusInfo { get; set; }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class StatusInfo
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class ExtensionPermissions
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Admin admin { get; set; }
                public InternationalCalling internationalCalling { get; set; }

                public class Admin
                {
                    public string @ref { get; set; }
                }

                public class InternationalCalling
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class ExtensionServiceFeatureInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Enabled enabled { get; set; }
                public FeatureName featureName { get; set; }
                public Reason reason { get; set; }

                public class Enabled
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class FeatureName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Reason
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class FormattingLocaleInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public LocaleCode localeCode { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LocaleCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ForwardingInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public NotifyMySoftPhones notifyMySoftPhones { get; set; }
                public NotifyAdminSoftPhones notifyAdminSoftPhones { get; set; }
                public SoftPhonesRingCount softPhonesRingCount { get; set; }
                public RingingMode ringingMode { get; set; }
                public Rules rules { get; set; }

                public class NotifyMySoftPhones
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class NotifyAdminSoftPhones
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class SoftPhonesRingCount
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class RingingMode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Rules
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }
            }
        }

        public class ForwardingNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public PhoneNumber phoneNumber { get; set; }
                public Label label { get; set; }
                public Features features { get; set; }
                public FlipNumber flipNumber { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Label
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Features
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class FlipNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class FullCountryInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public CallingCode callingCode { get; set; }
                public EmergencyCalling emergencyCalling { get; set; }
                public IsoCode isoCode { get; set; }
                public Name name { get; set; }
                public NumberSelling numberSelling { get; set; }
                public LoginAllowed loginAllowed { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class CallingCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class EmergencyCalling
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class IsoCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class NumberSelling
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LoginAllowed
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class GrantInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public Extension extension { get; set; }
                public CallPickup callPickup { get; set; }
                public CallMonitoring callMonitoring { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Extension
                {
                    public string @ref { get; set; }
                }

                public class CallPickup
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class CallMonitoring
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class GrantInfoExtensionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public ExtensionNumber extensionNumber { get; set; }
                public Type type { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class GreetingLanguageInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public LocaleCode localeCode { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LocaleCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class GroupInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public ContactsCount contactsCount { get; set; }
                public GroupName groupName { get; set; }
                public Notes notes { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ContactsCount
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class GroupName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Notes
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class LanguageInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Greeting greeting { get; set; }
                public FormattingLocale formattingLocale { get; set; }
                public LocaleCode localeCode { get; set; }
                public Name name { get; set; }
                public Ui ui { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Greeting
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class FormattingLocale
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LocaleCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Ui
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class LegInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Action action { get; set; }
                public Direction direction { get; set; }
                public Duration duration { get; set; }
                public Extension extension { get; set; }
                public LegType legType { get; set; }
                public StartTime startTime { get; set; }
                public Type type { get; set; }
                public Result result { get; set; }
                public From from { get; set; }
                public To to { get; set; }
                public Transport transport { get; set; }
                public Recording recording { get; set; }

                public class Action
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Direction
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Duration
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Extension
                {
                    public string @ref { get; set; }
                }

                public class LegType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class StartTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Result
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class From
                {
                    public string @ref { get; set; }
                }

                public class To
                {
                    public string @ref { get; set; }
                }

                public class Transport
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Recording
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class LegInfoExtensionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class LinksInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public StartUri startUri { get; set; }
                public JoinUri joinUri { get; set; }

                public class StartUri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class JoinUri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class LocationInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public AreaCode areaCode { get; set; }
                public City city { get; set; }
                public Npa npa { get; set; }
                public Nxx nxx { get; set; }
                public State state { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class AreaCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class City
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Npa
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Nxx
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class State
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class LookUpPhoneNumberPhoneNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }
                public FormattedNumber formattedNumber { get; set; }
                public VanityPattern vanityPattern { get; set; }
                public Rank rank { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class FormattedNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class VanityPattern
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Rank
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class MeetingInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public Id id { get; set; }
                public Topic topic { get; set; }
                public MeetingType meetingType { get; set; }
                public Password password { get; set; }
                public Status status { get; set; }
                public Links links { get; set; }
                public Schedule schedule { get; set; }
                public AllowJoinBeforeHost allowJoinBeforeHost { get; set; }
                public StartHostVideo startHostVideo { get; set; }
                public StartParticipantsVideo startParticipantsVideo { get; set; }
                public AudioOptions audioOptions { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Topic
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class MeetingType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Password
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Links
                {
                    public string @ref { get; set; }
                }

                public class Schedule
                {
                    public string @ref { get; set; }
                }

                public class AllowJoinBeforeHost
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class StartHostVideo
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class StartParticipantsVideo
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class AudioOptions
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string type { get; set; }
                    }
                }
            }
        }

        public class MeetingScheduleInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public StartTime startTime { get; set; }
                public DurationInMinutes durationInMinutes { get; set; }
                public TimeZone timeZone { get; set; }

                public class StartTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class DurationInMinutes
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class TimeZone
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class MeetingScheduleInfoTimezoneInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class MessageAttachmentInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Type type { get; set; }
                public ContentType contentType { get; set; }
                public VmDuration vmDuration { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class ContentType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class VmDuration
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class MessageInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Attachments attachments { get; set; }
                public Availability availability { get; set; }
                public ConversationId conversationId { get; set; }
                public CreationTime creationTime { get; set; }
                public DeliveryErrorCode deliveryErrorCode { get; set; }
                public Direction direction { get; set; }
                public FaxPageCount faxPageCount { get; set; }
                public FaxResolution faxResolution { get; set; }
                public From from { get; set; }
                public LastModifiedTime lastModifiedTime { get; set; }
                public MessageStatus messageStatus { get; set; }
                public PgToDepartment pgToDepartment { get; set; }
                public Priority priority { get; set; }
                public ReadStatus readStatus { get; set; }
                public SmsDeliveryTime smsDeliveryTime { get; set; }
                public SmsSendingAttemptsCount smsSendingAttemptsCount { get; set; }
                public Subject subject { get; set; }
                public To to { get; set; }
                public Type type { get; set; }
                public VmTranscriptionStatus vmTranscriptionStatus { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Attachments
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Availability
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class ConversationId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class CreationTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class DeliveryErrorCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Direction
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class FaxPageCount
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class FaxResolution
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class From
                {
                    public string @ref { get; set; }
                }

                public class LastModifiedTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class MessageStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class PgToDepartment
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Priority
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class ReadStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class SmsDeliveryTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class SmsSendingAttemptsCount
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Subject
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class To
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class VmTranscriptionStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class MessageInfoCallerInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public ExtensionNumber extensionNumber { get; set; }
                public Location location { get; set; }
                public MessageStatus messageStatus { get; set; }
                public FaxErrorCode faxErrorCode { get; set; }
                public Name name { get; set; }
                public PhoneNumber phoneNumber { get; set; }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Location
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class MessageStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class FaxErrorCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ModelInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Name name { get; set; }
                public Addons addons { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Addons
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }
            }
        }

        public class NavigationInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public FirstPage firstPage { get; set; }
                public NextPage nextPage { get; set; }
                public PreviousPage previousPage { get; set; }
                public LastPage lastPage { get; set; }

                public class FirstPage
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class NextPage
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PreviousPage
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LastPage
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class PagingInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Page page { get; set; }
                public PerPage perPage { get; set; }
                public PageStart pageStart { get; set; }
                public PageEnd pageEnd { get; set; }
                public TotalPages totalPages { get; set; }
                public TotalElements totalElements { get; set; }

                public class Page
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PerPage
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PageStart
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PageEnd
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class TotalPages
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class TotalElements
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ParsePhoneNumberCountryInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public CallingCode callingCode { get; set; }
                public EmergencyCalling emergencyCalling { get; set; }
                public IsoCode isoCode { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class CallingCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class EmergencyCalling
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class IsoCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ParsePhoneNumberPhoneNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public AreaCode areaCode { get; set; }
                public Country country { get; set; }
                public Dialable dialable { get; set; }
                public E164 e164 { get; set; }
                public FormattedInternational formattedInternational { get; set; }
                public FormattedNational formattedNational { get; set; }
                public OriginalString originalString { get; set; }
                public Special special { get; set; }
                public Normalized normalized { get; set; }

                public class AreaCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Country
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Dialable
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class E164
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class FormattedInternational
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class FormattedNational
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class OriginalString
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Special
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Normalized
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class PermissionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Enabled enabled { get; set; }

                public class Enabled
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class PersonalContactInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Url url { get; set; }
                public Availability availability { get; set; }
                public FirstName firstName { get; set; }
                public LastName lastName { get; set; }
                public MiddleName middleName { get; set; }
                public NickName nickName { get; set; }
                public Company company { get; set; }
                public JobTitle jobTitle { get; set; }
                public HomePhone homePhone { get; set; }
                public HomePhone2 homePhone2 { get; set; }
                public BusinessPhone businessPhone { get; set; }
                public BusinessPhone2 businessPhone2 { get; set; }
                public MobilePhone mobilePhone { get; set; }
                public BusinessFax businessFax { get; set; }
                public CompanyPhone companyPhone { get; set; }
                public AssistantPhone assistantPhone { get; set; }
                public CarPhone carPhone { get; set; }
                public OtherPhone otherPhone { get; set; }
                public OtherFax otherFax { get; set; }
                public CallbackPhone callbackPhone { get; set; }
                public Email email { get; set; }
                public Email2 email2 { get; set; }
                public Email3 email3 { get; set; }
                public HomeAddress homeAddress { get; set; }
                public BusinessAddress businessAddress { get; set; }
                public OtherAddress otherAddress { get; set; }
                public Birthday birthday { get; set; }
                public WebPage webPage { get; set; }
                public Notes notes { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Url
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Availability
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class FirstName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LastName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class MiddleName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class NickName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Company
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class JobTitle
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class HomePhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class HomePhone2
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class BusinessPhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class BusinessPhone2
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class MobilePhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class BusinessFax
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class CompanyPhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class AssistantPhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class CarPhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class OtherPhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class OtherFax
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class CallbackPhone
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Email
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Email2
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Email3
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class HomeAddress
                {
                    public string @ref { get; set; }
                }

                public class BusinessAddress
                {
                    public string @ref { get; set; }
                }

                public class OtherAddress
                {
                    public string @ref { get; set; }
                }

                public class Birthday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class WebPage
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Notes
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class PhoneLinesInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public LineType lineType { get; set; }
                public PhoneInfo phoneInfo { get; set; }

                public class LineType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class PhoneInfo
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class PhoneLinesInfoPhoneNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Country country { get; set; }
                public Location location { get; set; }
                public PaymentType paymentType { get; set; }
                public PhoneNumber phoneNumber { get; set; }
                public Status status { get; set; }
                public Type type { get; set; }
                public UsageType usageType { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Country
                {
                    public string @ref { get; set; }
                }

                public class Location
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PaymentType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class UsageType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class PhoneNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Country country { get; set; }
                public Extension extension { get; set; }
                public Features features { get; set; }
                public Location location { get; set; }
                public PaymentType paymentType { get; set; }
                public PhoneNumber phoneNumber { get; set; }
                public Status status { get; set; }
                public Type type { get; set; }
                public UsageType usageType { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Country
                {
                    public string @ref { get; set; }
                }

                public class Extension
                {
                    public string @ref { get; set; }
                }

                public class Features
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string type { get; set; }
                    }
                }

                public class Location
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PaymentType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class UsageType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class PhoneNumberInfoExtensionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public ExtensionNumber extensionNumber { get; set; }
                public PartnerId partnerId { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PartnerId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class PresenceInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public AllowSeeMyPresence allowSeeMyPresence { get; set; }
                public DndStatus dndStatus { get; set; }
                public Extension extension { get; set; }
                public Message message { get; set; }
                public PickUpCallsOnHold pickUpCallsOnHold { get; set; }
                public PresenceStatus presenceStatus { get; set; }
                public RingOnMonitoredCall ringOnMonitoredCall { get; set; }
                public TelephonyStatus telephonyStatus { get; set; }
                public UserStatus userStatus { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class AllowSeeMyPresence
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class DndStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Extension
                {
                    public string @ref { get; set; }
                }

                public class Message
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PickUpCallsOnHold
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PresenceStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class RingOnMonitoredCall
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class TelephonyStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class UserStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class PresenceInfoExtensionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public ExtensionNumber extensionNumber { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ExtensionNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ProfileImageInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public Etag etag { get; set; }
                public LastModified lastModified { get; set; }
                public ContentType contentType { get; set; }
                public Scales scales { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Etag
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class LastModified
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class ContentType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Scales
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string type { get; set; }
                    }
                }
            }
        }

        public class RangesInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public From from { get; set; }
                public To to { get; set; }

                public class From
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class To
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }
            }
        }

        public class RecipientInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public Id id { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class RecordingInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Type type { get; set; }
                public ContentUri contentUri { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class ContentUri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ReferenceInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Ref @ref { get; set; }
                public Type type { get; set; }

                public class Ref
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Type
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class RegionalSettings
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public HomeCountry homeCountry { get; set; }
                public Timezone timezone { get; set; }
                public Language language { get; set; }
                public GreetingLanguage greetingLanguage { get; set; }
                public FormattingLocale formattingLocale { get; set; }

                public class HomeCountry
                {
                    public string @ref { get; set; }
                }

                public class Timezone
                {
                    public string @ref { get; set; }
                }

                public class Language
                {
                    public string @ref { get; set; }
                }

                public class GreetingLanguage
                {
                    public string @ref { get; set; }
                }

                public class FormattingLocale
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class ReservePhoneNumberRequestReserveRecord
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }
                public ReservedTill reservedTill { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ReservedTill
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }
            }
        }

        public class ReservePhoneNumberResponseReserveRecord
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }
                public FormattedNumber formattedNumber { get; set; }
                public ReservedTill reservedTill { get; set; }
                public ReservationId reservationId { get; set; }
                public Status status { get; set; }
                public Error error { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class FormattedNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ReservedTill
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class ReservationId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Error
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class RingOutRequestCountryInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class RingOutRequestFrom
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }
                public ForwardingNumberId forwardingNumberId { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ForwardingNumberId
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class RingOutRequestTo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class RingOutInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Status status { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Status
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class RingOutStatusInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public CallStatus callStatus { get; set; }
                public CallerStatus callerStatus { get; set; }
                public CalleeStatus calleeStatus { get; set; }

                public class CallStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class CallerStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class CalleeStatus
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class RuleInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Index index { get; set; }
                public RingCount ringCount { get; set; }
                public ForwardingNumbers forwardingNumbers { get; set; }

                public class Index
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class RingCount
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ForwardingNumbers
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }
            }
        }

        public class RuleInfoForwardingNumberInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public Id id { get; set; }
                public PhoneNumber phoneNumber { get; set; }
                public Label label { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Label
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ScheduleInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public WeeklyRanges weeklyRanges { get; set; }
                public Ranges ranges { get; set; }
                public Ref @ref { get; set; }

                public class WeeklyRanges
                {
                    public string @ref { get; set; }
                }

                public class Ranges
                {
                    public string @ref { get; set; }
                }

                public class Ref
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class ServerInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public ApiVersions apiVersions { get; set; }
                public ServerVersion serverVersion { get; set; }
                public ServerRevision serverRevision { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ApiVersions
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class ServerVersion
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ServerRevision
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ServiceFeatureInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public FeatureName featureName { get; set; }
                public Enabled enabled { get; set; }

                public class FeatureName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Enabled
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ServiceInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public BillingPlan billingPlan { get; set; }
                public Brand brand { get; set; }
                public ServicePlan servicePlan { get; set; }
                public TargetServicePlan targetServicePlan { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class BillingPlan
                {
                    public string @ref { get; set; }
                }

                public class Brand
                {
                    public string @ref { get; set; }
                }

                public class ServicePlan
                {
                    public string @ref { get; set; }
                }

                public class TargetServicePlan
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class ServicePlanInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Name name { get; set; }
                public Edition edition { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Edition
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ShippingAddress
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public CustomerName customerName { get; set; }
                public Street street { get; set; }
                public Street2 street2 { get; set; }
                public City city { get; set; }
                public State state { get; set; }
                public Zip zip { get; set; }
                public Country country { get; set; }

                public class CustomerName
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Street
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Street2
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class City
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class State
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Zip
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Country
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class ShippingInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Status status { get; set; }
                public Carrier carrier { get; set; }
                public TrackingNumber trackingNumber { get; set; }
                public Method method { get; set; }
                public Address address { get; set; }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Carrier
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class TrackingNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Method
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Address
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }
            }
        }

        public class ShippingMethod
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class StateInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Country country { get; set; }
                public IsoCode isoCode { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Country
                {
                    public string @ref { get; set; }
                }

                public class IsoCode
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class StateInfoCountryInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class StatusInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Comment comment { get; set; }
                public Reason reason { get; set; }

                public class Comment
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Reason
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }
            }
        }

        public class SubscriptionRequestDeliveryMode
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public TransportType transportType { get; set; }
                public Encryption encryption { get; set; }

                public class TransportType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class Encryption
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class SubscriptionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public EventFilters eventFilters { get; set; }
                public ExpirationTime expirationTime { get; set; }
                public ExpiresIn expiresIn { get; set; }
                public Status status { get; set; }
                public CreationTime creationTime { get; set; }
                public DeliveryMode deliveryMode { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class EventFilters
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string type { get; set; }
                    }
                }

                public class ExpirationTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class ExpiresIn
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Status
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class CreationTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class DeliveryMode
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class SyncInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public SyncType syncType { get; set; }
                public SyncToken syncToken { get; set; }
                public SyncTime syncTime { get; set; }

                public class SyncType
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                }

                public class SyncToken
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class SyncTime
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }
            }
        }

        public class TargetServicePlanInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Name name { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class TimeInterval
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public From from { get; set; }
                public To to { get; set; }

                public class From
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }

                public class To
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string format { get; set; }
                }
            }
        }

        public class TimezoneInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Id id { get; set; }
                public Uri uri { get; set; }
                public Name name { get; set; }
                public Description description { get; set; }

                public class Id
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Name
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Description
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class UnconditionalForwardingInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public PhoneNumber phoneNumber { get; set; }

                public class PhoneNumber
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class VersionInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Uri uri { get; set; }
                public VersionString versionString { get; set; }
                public ReleaseDate releaseDate { get; set; }
                public UriString uriString { get; set; }

                public class Uri
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class VersionString
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class ReleaseDate
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class UriString
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }
            }
        }

        public class VoicemailInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Enabled enabled { get; set; }
                public Recipient recipient { get; set; }

                public class Enabled
                {
                    public string type { get; set; }
                    public string description { get; set; }
                }

                public class Recipient
                {
                    public string @ref { get; set; }
                }
            }
        }

        public class WeeklyScheduleInfo
        {
            public string type { get; set; }
            public Properties properties { get; set; }

            public class Properties
            {
                public Monday monday { get; set; }
                public Tuesday tuesday { get; set; }
                public Wednesday wednesday { get; set; }
                public Thursday thursday { get; set; }
                public Friday friday { get; set; }
                public Saturday saturday { get; set; }
                public Sunday sunday { get; set; }

                public class Monday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Tuesday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Wednesday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Thursday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Friday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Saturday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }

                public class Sunday
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public Items items { get; set; }

                    public class Items
                    {
                        public string @ref { get; set; }
                    }
                }
            }
        }
    }

    public class Paths
    {
        public Restapi /restapi { get; set; }
        public RestapiOauthAuthorize /restapi/oauth/authorize { get; set; }
        public RestapiOauthRevoke /restapi/oauth/revoke { get; set; }
        public RestapiOauthToken /restapi/oauth/token { get; set; }
        public RestapiV1_0 /restapi/v1.0 { get; set; }
        public RestapiV1_0AccountAccountId /restapi/v1.0/account/{accountId} { get; set; }
        public RestapiV1_0AccountAccountIdActiveCalls /restapi/v1.0/account/{accountId}/active-calls { get; set; }
        public RestapiV1_0AccountAccountIdBusinessAddress /restapi/v1.0/account/{accountId}/business-address { get; set; }
        public RestapiV1_0AccountAccountIdCallLog /restapi/v1.0/account/{accountId}/call-log { get; set; }
        public RestapiV1_0AccountAccountIdCallLogCallLogId /restapi/v1.0/account/{accountId}/call-log/{callLogId} { get; set; }
        public RestapiV1_0AccountAccountIdExtension /restapi/v1.0/account/{accountId}/extension { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionId /restapi/v1.0/account/{accountId}/extension/{extensionId} { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdActiveCalls /restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdCallLog /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdCallLogCallLogId /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callLogId} { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdCompanyPager /restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdFax /restapi/v1.0/account/{accountId}/extension/{extensionId}/fax { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdForwardingNumber /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStore /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageId /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId} { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentId /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId} { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdPhoneNumber /restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdPresence /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdRingout /restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdRingoutRingoutId /restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId} { get; set; }
        public RestapiV1_0AccountAccountIdExtensionExtensionIdSms /restapi/v1.0/account/{accountId}/extension/{extensionId}/sms { get; set; }
        public RestapiV1_0AccountAccountIdPhoneNumber /restapi/v1.0/account/{accountId}/phone-number { get; set; }
        public RestapiV1_0AccountAccountIdPhoneNumberPhoneNumberId /restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId} { get; set; }
        public RestapiV1_0AccountAccountIdRecordingRecordingId /restapi/v1.0/account/{accountId}/recording/{recordingId} { get; set; }
        public RestapiV1_0AccountAccountIdRecordingRecordingIdContent /restapi/v1.0/account/{accountId}/recording/{recordingId}/content { get; set; }
        public RestapiV1_0DictionaryCountry /restapi/v1.0/dictionary/country { get; set; }
        public RestapiV1_0DictionaryCountryCountryId /restapi/v1.0/dictionary/country/{countryId} { get; set; }
        public RestapiV1_0DictionaryLanguage /restapi/v1.0/dictionary/language { get; set; }
        public RestapiV1_0DictionaryLanguageLanguageId /restapi/v1.0/dictionary/language/{languageId} { get; set; }
        public RestapiV1_0DictionaryLocation /restapi/v1.0/dictionary/location { get; set; }
        public RestapiV1_0DictionaryState /restapi/v1.0/dictionary/state { get; set; }
        public RestapiV1_0DictionaryStateStateId /restapi/v1.0/dictionary/state/{stateId} { get; set; }
        public RestapiV1_0DictionaryTimezone /restapi/v1.0/dictionary/timezone { get; set; }
        public RestapiV1_0DictionaryTimezoneTimezoneId /restapi/v1.0/dictionary/timezone/{timezoneId} { get; set; }
        public RestapiV1_0Subscription /restapi/v1.0/subscription { get; set; }
        public RestapiV1_0SubscriptionSubscriptionId /restapi/v1.0/subscription/{subscriptionId} { get; set; }

        public class Restapi
        {
            public Get get { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }
        }

        public class RestapiOauthAuthorize
        {
            public Post post { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Code code { get; set; }
                                public ExpiresIn expires_in { get; set; }
                                public State state { get; set; }

                                public class Code
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class ExpiresIn
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class State
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public ResponseType response_type { get; set; }
                            public ClientId client_id { get; set; }
                            public RedirectUri redirect_uri { get; set; }
                            public State state { get; set; }

                            public class ResponseType
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class ClientId
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class RedirectUri
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class State
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }
                        }
                    }
                }
            }
        }

        public class RestapiOauthRevoke
        {
            public Post post { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public Token token { get; set; }

                            public class Token
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }
                        }
                    }
                }
            }
        }

        public class RestapiOauthToken
        {
            public Post post { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public AccessToken access_token { get; set; }
                                public ExpiresIn expires_in { get; set; }
                                public RefreshToken refresh_token { get; set; }
                                public RefreshTokenExpiresIn refresh_token_expires_in { get; set; }
                                public Scope scope { get; set; }
                                public TokenType token_type { get; set; }
                                public OwnerId owner_id { get; set; }
                                public EndpointId endpoint_id { get; set; }

                                public class AccessToken
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class ExpiresIn
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class RefreshToken
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class RefreshTokenExpiresIn
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class Scope
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class TokenType
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class OwnerId
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class EndpointId
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public GrantType grant_type { get; set; }
                            public AccessTokenTtl access_token_ttl { get; set; }
                            public RefreshTokenTtl refresh_token_ttl { get; set; }
                            public Username username { get; set; }
                            public Extension extension { get; set; }
                            public Password password { get; set; }
                            public Scope scope { get; set; }
                            public EndpointId endpoint_id { get; set; }

                            public class GrantType
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class AccessTokenTtl
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class RefreshTokenTtl
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class Username
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class Extension
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class Password
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class Scope
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class EndpointId
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }
                        }
                    }
                }
            }
        }

        public class RestapiV1_0
        {
            public Get get { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }
        }

        public class RestapiV1_0AccountAccountId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdActiveCalls
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdBusinessAddress
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Uri uri { get; set; }
                                public Company company { get; set; }
                                public Email email { get; set; }
                                public BusinessAddress businessAddress { get; set; }

                                public class Uri
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class Company
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class Email
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class BusinessAddress
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdCallLog
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public string[] @enum { get; set; }
                    public string format { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdCallLogCallLogId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtension
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public string[] @enum { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdActiveCalls
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdCallLog
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public string[] @enum { get; set; }
                    public string format { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdCallLogCallLogId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdCompanyPager
        {
            public Post post { get; set; }
            public Parameter[] parameters { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public From from { get; set; }
                            public ReplyOn replyOn { get; set; }
                            public Text text { get; set; }
                            public To to { get; set; }

                            public class From
                            {
                                public string @ref { get; set; }
                            }

                            public class ReplyOn
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class Text
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class To
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public Items items { get; set; }

                                public class Items
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdFax
        {
            public Post post { get; set; }
            public Parameter[] parameters { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public To to { get; set; }
                            public Resolution resolution { get; set; }
                            public SendTime sendTime { get; set; }
                            public CoverIndex coverIndex { get; set; }
                            public CoverPageText coverPageText { get; set; }
                            public OriginalMessageId originalMessageId { get; set; }

                            public class To
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public Items items { get; set; }

                                public class Items
                                {
                                    public string @ref { get; set; }
                                }
                            }

                            public class Resolution
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public string[] @enum { get; set; }
                            }

                            public class SendTime
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public string format { get; set; }
                            }

                            public class CoverIndex
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class CoverPageText
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class OriginalMessageId
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdForwardingNumber
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStore
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public string format { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageId
        {
            public Delete delete { get; set; }
            public Get get { get; set; }
            public Put put { get; set; }
            public Parameter[] parameters { get; set; }

            public class Delete
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public string format { get; set; }
                }
            }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Put
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public ReadStatus readStatus { get; set; }

                            public class ReadStatus
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public string[] @enum { get; set; }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public string format { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdPhoneNumber
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdPresence
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdRingout
        {
            public Post post { get; set; }
            public Parameter[] parameters { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public From from { get; set; }
                            public To to { get; set; }
                            public CallerId callerId { get; set; }
                            public PlayPrompt playPrompt { get; set; }
                            public Country country { get; set; }

                            public class From
                            {
                                public string @ref { get; set; }
                            }

                            public class To
                            {
                                public string @ref { get; set; }
                            }

                            public class CallerId
                            {
                                public string @ref { get; set; }
                            }

                            public class PlayPrompt
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }

                            public class Country
                            {
                                public string @ref { get; set; }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdRingoutRingoutId
        {
            public Delete delete { get; set; }
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Delete
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                    }
                }
            }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdSms
        {
            public Post post { get; set; }
            public Parameter[] parameters { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }

                public class Parameter
                {
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public From from { get; set; }
                            public To to { get; set; }
                            public Text text { get; set; }

                            public class From
                            {
                                public string @ref { get; set; }
                            }

                            public class To
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public Items items { get; set; }

                                public class Items
                                {
                                    public string @ref { get; set; }
                                }
                            }

                            public class Text
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdPhoneNumber
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Paging paging { get; set; }
                                public Navigation navigation { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public string[] @enum { get; set; }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdPhoneNumberPhoneNumberId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdRecordingRecordingId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Id id { get; set; }
                                public ContentUri contentUri { get; set; }
                                public ContentType contentType { get; set; }
                                public Duration duration { get; set; }

                                public class Id
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class ContentUri
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class ContentType
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }

                                public class Duration
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0AccountAccountIdRecordingRecordingIdContent
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public string format { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0DictionaryCountry
        {
            public Get get { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }
        }

        public class RestapiV1_0DictionaryCountryCountryId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0DictionaryLanguage
        {
            public Get get { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }
            }
        }

        public class RestapiV1_0DictionaryLanguageLanguageId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0DictionaryLocation
        {
            public Get get { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string[] @enum { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }
        }

        public class RestapiV1_0DictionaryState
        {
            public Get get { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }
        }

        public class RestapiV1_0DictionaryStateStateId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0DictionaryTimezone
        {
            public Get get { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string type { get; set; }
                            public Properties properties { get; set; }

                            public class Properties
                            {
                                public Records records { get; set; }
                                public Navigation navigation { get; set; }
                                public Paging paging { get; set; }

                                public class Records
                                {
                                    public string type { get; set; }
                                    public string description { get; set; }
                                    public Items items { get; set; }

                                    public class Items
                                    {
                                        public string @ref { get; set; }
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref { get; set; }
                                }

                                public class Paging
                                {
                                    public string @ref { get; set; }
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                }
            }
        }

        public class RestapiV1_0DictionaryTimezoneTimezoneId
        {
            public Get get { get; set; }
            public Parameter[] parameters { get; set; }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }

        public class RestapiV1_0Subscription
        {
            public Post post { get; set; }

            public class Post
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public EventFilters eventFilters { get; set; }
                            public DeliveryMode deliveryMode { get; set; }

                            public class EventFilters
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public Items items { get; set; }

                                public class Items
                                {
                                    public string type { get; set; }
                                }
                            }

                            public class DeliveryMode
                            {
                                public string @ref { get; set; }
                            }
                        }
                    }
                }
            }
        }

        public class RestapiV1_0SubscriptionSubscriptionId
        {
            public Delete delete { get; set; }
            public Get get { get; set; }
            public Put put { get; set; }
            public Parameter[] parameters { get; set; }

            public class Delete
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                    }
                }
            }

            public class Get
            {
                public string description { get; set; }
                public Responses responses { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }
            }

            public class Put
            {
                public string description { get; set; }
                public Responses responses { get; set; }
                public Parameter[] parameters { get; set; }

                public class Responses
                {
                    public Default @default { get; set; }

                    public class Default
                    {
                        public string description { get; set; }
                        public Schema schema { get; set; }

                        public class Schema
                        {
                            public string @ref { get; set; }
                        }
                    }
                }

                public class Parameter
                {
                    public string type { get; set; }
                    public string description { get; set; }
                    public string name { get; set; }
                    public string @in { get; set; }
                    public Schema schema { get; set; }

                    public class Schema
                    {
                        public string type { get; set; }
                        public Properties properties { get; set; }

                        public class Properties
                        {
                            public EventFilters eventFilters { get; set; }

                            public class EventFilters
                            {
                                public string type { get; set; }
                                public string description { get; set; }
                                public Items items { get; set; }

                                public class Items
                                {
                                    public string type { get; set; }
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref { get; set; }
            }
        }
    }
}