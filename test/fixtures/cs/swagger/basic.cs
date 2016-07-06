public partial class Swagger
{
    public string swagger;
    public Info info;
    public string host;
    public string basePath;
    public string[] schemes;
    public string[] produces;
    public string[] consumes;
    public SecurityDefinition securityDefinitions;
    public Security[] security;
    public Parameter parameters;
    public Definition definitions;
    public Path paths;

    public class Info
    {
        public string version;
        public string title;
        public string description;
        public string termsOfService;
    }

    public class SecurityDefinition
    {
        public Oauth oauth;

        public class Oauth
        {
            public string type;
            public string flow;
            public string authorizationUrl;
            public string tokenUrl;
            public Scope scopes;

            public class Scope
            {
                public string @default;
            }
        }
    }

    public class Security
    {
        public string[] oauth;
    }

    public class Parameter
    {
        public AccountId accountId;
        public AnsweringRuleId answeringRuleId;
        public AttachmentId attachmentId;
        public BlockedNumberId blockedNumberId;
        public BrandId brandId;
        public CallLogId callLogId;
        public CompanyPagerId companyPagerId;
        public ContactId contactId;
        public CountryId countryId;
        public CustomDataKey customDataKey;
        public DepartmentId departmentId;
        public DeviceId deviceId;
        public ExtensionId extensionId;
        public FaxId faxId;
        public GroupId groupId;
        public LanguageId languageId;
        public LineId lineId;
        public MessageId messageId;
        public OrderId orderId;
        public PhoneNumberId phoneNumberId;
        public RecordingId recordingId;
        public RingoutId ringoutId;
        public ScaleSize scaleSize;
        public SecretQuestionId secretQuestionId;
        public ServicePlanId servicePlanId;
        public SmsId smsId;
        public StateId stateId;
        public SubscriptionId subscriptionId;
        public TimezoneId timezoneId;
        public UserGroupId userGroupId;
        public VerificationCallId verificationCallId;

        public class AccountId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
            public string @default;
        }

        public class AnsweringRuleId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class AttachmentId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class BlockedNumberId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class BrandId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class CallLogId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class CompanyPagerId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class ContactId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class CountryId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class CustomDataKey
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class DepartmentId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class DeviceId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class ExtensionId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
            public string @default;
        }

        public class FaxId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class GroupId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class LanguageId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class LineId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class MessageId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class OrderId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class PhoneNumberId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class RecordingId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class RingoutId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class ScaleSize
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
            public string[] @enum;
        }

        public class SecretQuestionId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class ServicePlanId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class SmsId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class StateId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class SubscriptionId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class TimezoneId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class UserGroupId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }

        public class VerificationCallId
        {
            public string name;
            public string @in;
            public bool required;
            public string type;
            public string description;
        }
    }

    public class Definition
    {
        public AccountInfo accountInfo;
        public AccountLimit accountLimits;
        public AddonInfo addonInfo;
        public AnsweringRuleInfo answeringRuleInfo;
        public AnsweringRuleInfoCalleeInfo answeringRuleInfoCalleeInfo;
        public AnsweringRuleInfoCallerInfo answeringRuleInfoCallerInfo;
        public AttachmentInfo attachmentInfo;
        public BillingPlanInfo billingPlanInfo;
        public BlockedNumberInfo blockedNumberInfo;
        public BrandInfo brandInfo;
        public BusinessAddressInfo businessAddressInfo;
        public BusinessHourScheduleInfo businessHourScheduleInfo;
        public CallLogInfo callLogInfo;
        public CallLogRecord callLogRecord;
        public CallerInfo callerInfo;
        public ConferencingRequestPhoneNumber conferencingRequestPhoneNumber;
        public ConferencingInfo conferencingInfo;
        public ConferencingInfoPhoneNumberInfo conferencingInfoPhoneNumberInfo;
        public ConferencingInfoPhoneNumberInfoCountryInfo conferencingInfoPhoneNumberInfoCountryInfo;
        public ContactAddressInfo contactAddressInfo;
        public ContactInfo contactInfo;
        public CountryInfo countryInfo;
        public DeliveryMode deliveryMode;
        public DepartmentResponseExtensionInfo departmentResponseExtensionInfo;
        public DepartmentInfo departmentInfo;
        public DeviceInfo deviceInfo;
        public DeviceInfoExtensionInfo deviceInfoExtensionInfo;
        public EmergencyAddressInfo emergencyAddressInfo;
        public ExtensionInfo extensionInfo;
        public ExtensionInfoRequestContactInfo extensionInfoRequestContactInfo;
        public ExtensionInfoRequestContactInfoRegionalSetting extensionInfoRequestContactInfoRegionalSettings;
        public ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale extensionInfoRequestContactInfoRegionalSettingsFormattingLocale;
        public ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage extensionInfoRequestContactInfoRegionalSettingsGreetingLanguage;
        public ExtensionInfoRequestContactInfoRegionalSettingsLanguage extensionInfoRequestContactInfoRegionalSettingsLanguage;
        public ExtensionInfoRequestContactInfoRegionalSettingsTimezone extensionInfoRequestContactInfoRegionalSettingsTimezone;
        public ExtensionInfoRequestPartnerId extensionInfoRequestPartnerId;
        public ExtensionInfoRequestPasswordPin extensionInfoRequestPasswordPin;
        public ExtensionInfoRequestProvision extensionInfoRequestProvision;
        public ExtensionInfoRequestProvisionContactInfo extensionInfoRequestProvisionContactInfo;
        public ExtensionInfoRequestStatusInfo extensionInfoRequestStatusInfo;
        public ExtensionPermission extensionPermissions;
        public ExtensionServiceFeatureInfo extensionServiceFeatureInfo;
        public FormattingLocaleInfo formattingLocaleInfo;
        public ForwardingInfo forwardingInfo;
        public ForwardingNumberInfo forwardingNumberInfo;
        public FullCountryInfo fullCountryInfo;
        public GrantInfo grantInfo;
        public GrantInfoExtensionInfo grantInfoExtensionInfo;
        public GreetingLanguageInfo greetingLanguageInfo;
        public GroupInfo groupInfo;
        public LanguageInfo languageInfo;
        public LegInfo legInfo;
        public LegInfoExtensionInfo legInfoExtensionInfo;
        public LinksInfo linksInfo;
        public LocationInfo locationInfo;
        public LookUpPhoneNumberPhoneNumberInfo lookUpPhoneNumberPhoneNumberInfo;
        public MeetingInfo meetingInfo;
        public MeetingScheduleInfo meetingScheduleInfo;
        public MeetingScheduleInfoTimezoneInfo meetingScheduleInfoTimezoneInfo;
        public MessageAttachmentInfo messageAttachmentInfo;
        public MessageInfo messageInfo;
        public MessageInfoCallerInfo messageInfoCallerInfo;
        public ModelInfo modelInfo;
        public NavigationInfo navigationInfo;
        public PagingInfo pagingInfo;
        public ParsePhoneNumberCountryInfo parsePhoneNumberCountryInfo;
        public ParsePhoneNumberPhoneNumberInfo parsePhoneNumberPhoneNumberInfo;
        public PermissionInfo permissionInfo;
        public PersonalContactInfo personalContactInfo;
        public PhoneLinesInfo phoneLinesInfo;
        public PhoneLinesInfoPhoneNumberInfo phoneLinesInfoPhoneNumberInfo;
        public PhoneNumberInfo phoneNumberInfo;
        public PhoneNumberInfoExtensionInfo phoneNumberInfoExtensionInfo;
        public PresenceInfo presenceInfo;
        public PresenceInfoExtensionInfo presenceInfoExtensionInfo;
        public ProfileImageInfo profileImageInfo;
        public RangesInfo rangesInfo;
        public RecipientInfo recipientInfo;
        public RecordingInfo recordingInfo;
        public ReferenceInfo referenceInfo;
        public RegionalSetting regionalSettings;
        public ReservePhoneNumberRequestReserveRecord reservePhoneNumberRequestReserveRecord;
        public ReservePhoneNumberResponseReserveRecord reservePhoneNumberResponseReserveRecord;
        public RingOutRequestCountryInfo ringOutRequestCountryInfo;
        public RingOutRequestFrom ringOutRequestFrom;
        public RingOutRequestTo ringOutRequestTo;
        public RingOutInfo ringOutInfo;
        public RingOutStatusInfo ringOutStatusInfo;
        public RuleInfo ruleInfo;
        public RuleInfoForwardingNumberInfo ruleInfoForwardingNumberInfo;
        public ScheduleInfo scheduleInfo;
        public ServerInfo serverInfo;
        public ServiceFeatureInfo serviceFeatureInfo;
        public ServiceInfo serviceInfo;
        public ServicePlanInfo servicePlanInfo;
        public ShippingAddress shippingAddress;
        public ShippingInfo shippingInfo;
        public ShippingMethod shippingMethod;
        public StateInfo stateInfo;
        public StateInfoCountryInfo stateInfoCountryInfo;
        public StatusInfo statusInfo;
        public SubscriptionRequestDeliveryMode subscriptionRequestDeliveryMode;
        public SubscriptionInfo subscriptionInfo;
        public SyncInfo syncInfo;
        public TargetServicePlanInfo targetServicePlanInfo;
        public TimeInterval timeInterval;
        public TimezoneInfo timezoneInfo;
        public UnconditionalForwardingInfo unconditionalForwardingInfo;
        public VersionInfo versionInfo;
        public VoicemailInfo voicemailInfo;
        public WeeklyScheduleInfo weeklyScheduleInfo;

        public class AccountInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public MainNumber mainNumber;
                public Operator @operator;
                public PartnerId partnerId;
                public ServiceInfo serviceInfo;
                public SetupWizardState setupWizardState;
                public Status status;
                public StatusInfo statusInfo;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class MainNumber
                {
                    public string type;
                    public string description;
                }

                public class Operator
                {
                    public string @ref;
                }

                public class PartnerId
                {
                    public string type;
                    public string description;
                }

                public class ServiceInfo
                {
                    public string @ref;
                }

                public class SetupWizardState
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class StatusInfo
                {
                    public string @ref;
                }
            }
        }

        public class AccountLimit
        {
            public string type;
            public Property properties;

            public class Property
            {
                public FreeSoftPhoneLinesPerExtension freeSoftPhoneLinesPerExtension;
                public MeetingSize meetingSize;
                public MaxMonitoredExtensionsPerUser maxMonitoredExtensionsPerUser;

                public class FreeSoftPhoneLinesPerExtension
                {
                    public string type;
                    public string description;
                }

                public class MeetingSize
                {
                    public string type;
                    public string description;
                }

                public class MaxMonitoredExtensionsPerUser
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class AddonInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Count count;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Count
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class AnsweringRuleInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public Id id;
                public Type type;
                public Name name;
                public Enabled enabled;
                public Schedule schedule;
                public CalledNumber calledNumbers;
                public Caller callers;
                public CallHandlingAction callHandlingAction;
                public Forwarding forwarding;
                public UnconditionalForwarding unconditionalForwarding;
                public Voicemail voicemail;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class Enabled
                {
                    public string type;
                    public string description;
                }

                public class Schedule
                {
                    public string @ref;
                }

                public class CalledNumber
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Caller
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class CallHandlingAction
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Forwarding
                {
                    public string @ref;
                }

                public class UnconditionalForwarding
                {
                    public string @ref;
                }

                public class Voicemail
                {
                    public string @ref;
                }
            }
        }

        public class AnsweringRuleInfoCalleeInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class AnsweringRuleInfoCallerInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public CallerId callerId;
                public Name name;

                public class CallerId
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class AttachmentInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public ContentType contentType;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ContentType
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class BillingPlanInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Name name;
                public DurationUnit durationUnit;
                public Duration duration;
                public Type type;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class DurationUnit
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Duration
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class BlockedNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Name name;
                public PhoneNumber phoneNumber;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class BrandInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Name name;
                public HomeCountry homeCountry;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class HomeCountry
                {
                    public string @ref;
                }
            }
        }

        public class BusinessAddressInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Country country;
                public State state;
                public City city;
                public Street street;
                public Zip zip;

                public class Country
                {
                    public string type;
                    public string description;
                }

                public class State
                {
                    public string type;
                    public string description;
                }

                public class City
                {
                    public string type;
                    public string description;
                }

                public class Street
                {
                    public string type;
                    public string description;
                }

                public class Zip
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class BusinessHourScheduleInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public WeeklyRange weeklyRanges;

                public class WeeklyRange
                {
                    public string @ref;
                }
            }
        }

        public class CallLogInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public SessionId sessionId;
                public From from;
                public To to;
                public Type type;
                public Direction direction;
                public Action action;
                public Result result;
                public StartTime startTime;
                public Duration duration;
                public Recording recording;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class SessionId
                {
                    public string type;
                    public string description;
                }

                public class From
                {
                    public string @ref;
                }

                public class To
                {
                    public string @ref;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Direction
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Action
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Result
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class StartTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class Duration
                {
                    public string type;
                    public string description;
                }

                public class Recording
                {
                    public string @ref;
                }
            }
        }

        public class CallLogRecord
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public SessionId sessionId;
                public From from;
                public To to;
                public Type type;
                public Direction direction;
                public Action action;
                public Result result;
                public StartTime startTime;
                public Duration duration;
                public Recording recording;
                public LastModifiedTime lastModifiedTime;
                public Transport transport;
                public Leg legs;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class SessionId
                {
                    public string type;
                    public string description;
                }

                public class From
                {
                    public string @ref;
                }

                public class To
                {
                    public string @ref;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Direction
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Action
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Result
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class StartTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class Duration
                {
                    public string type;
                    public string description;
                }

                public class Recording
                {
                    public string @ref;
                }

                public class LastModifiedTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class Transport
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Leg
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }
            }
        }

        public class CallerInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;
                public ExtensionNumber extensionNumber;
                public Location location;
                public Name name;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }

                public class Location
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ConferencingRequestPhoneNumber
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;
                public Default @default;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class Default
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ConferencingInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public AllowJoinBeforeHost allowJoinBeforeHost;
                public HostCode hostCode;
                public Mode mode;
                public ParticipantCode participantCode;
                public PhoneNumber phoneNumber;
                public TapToJoinUri tapToJoinUri;
                public PhoneNumber phoneNumbers;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class AllowJoinBeforeHost
                {
                    public string type;
                    public string description;
                }

                public class HostCode
                {
                    public string type;
                    public string description;
                }

                public class Mode
                {
                    public string type;
                    public string description;
                }

                public class ParticipantCode
                {
                    public string type;
                    public string description;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class TapToJoinUri
                {
                    public string type;
                    public string description;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }
            }
        }

        public class ConferencingInfoPhoneNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Country country;
                public Default @default;
                public HasGreeting hasGreeting;
                public Location location;
                public PhoneNumber phoneNumber;

                public class Country
                {
                    public string @ref;
                }

                public class Default
                {
                    public string type;
                    public string description;
                }

                public class HasGreeting
                {
                    public string type;
                    public string description;
                }

                public class Location
                {
                    public string type;
                    public string description;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ConferencingInfoPhoneNumberInfoCountryInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public CallingCode callingCode;
                public EmergencyCalling emergencyCalling;
                public IsoCode isoCode;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class CallingCode
                {
                    public string type;
                    public string description;
                }

                public class EmergencyCalling
                {
                    public string type;
                    public string description;
                }

                public class IsoCode
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ContactAddressInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Country country;
                public State state;
                public City city;
                public Street street;
                public Zip zip;

                public class Country
                {
                    public string type;
                    public string description;
                }

                public class State
                {
                    public string type;
                    public string description;
                }

                public class City
                {
                    public string type;
                    public string description;
                }

                public class Street
                {
                    public string type;
                    public string description;
                }

                public class Zip
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ContactInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public FirstName firstName;
                public LastName lastName;
                public Company company;
                public Email email;
                public BusinessPhone businessPhone;
                public BusinessAddress businessAddress;

                public class FirstName
                {
                    public string type;
                    public string description;
                }

                public class LastName
                {
                    public string type;
                    public string description;
                }

                public class Company
                {
                    public string type;
                    public string description;
                }

                public class Email
                {
                    public string type;
                    public string description;
                }

                public class BusinessPhone
                {
                    public string type;
                    public string description;
                }

                public class BusinessAddress
                {
                    public string @ref;
                }
            }
        }

        public class CountryInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class DeliveryMode
        {
            public string type;
            public Property properties;

            public class Property
            {
                public TransportType transportType;
                public Encryption encryption;
                public Address address;
                public SubscriberKey subscriberKey;
                public SecretKey secretKey;
                public EncryptionAlgorithm encryptionAlgorithm;
                public EncryptionKey encryptionKey;

                public class TransportType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Encryption
                {
                    public string type;
                    public string description;
                }

                public class Address
                {
                    public string type;
                    public string description;
                }

                public class SubscriberKey
                {
                    public string type;
                    public string description;
                }

                public class SecretKey
                {
                    public string type;
                    public string description;
                }

                public class EncryptionAlgorithm
                {
                    public string type;
                    public string description;
                }

                public class EncryptionKey
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class DepartmentResponseExtensionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public ExtensionNumber extensionNumber;
                public PartnerId partnerId;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }

                public class PartnerId
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class DepartmentInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public ExtensionNumber extensionNumber;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class DeviceInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Sku sku;
                public Type type;
                public Name name;
                public Serial serial;
                public ComputerName computerName;
                public Model model;
                public Extension extension;
                public EmergencyServiceAddress emergencyServiceAddress;
                public PhoneLine phoneLines;
                public Shipping shipping;
                public BoxBillingId boxBillingId;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Sku
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class Serial
                {
                    public string type;
                    public string description;
                }

                public class ComputerName
                {
                    public string type;
                    public string description;
                }

                public class Model
                {
                    public string @ref;
                }

                public class Extension
                {
                    public string @ref;
                }

                public class EmergencyServiceAddress
                {
                    public string @ref;
                }

                public class PhoneLine
                {
                    public string @ref;
                }

                public class Shipping
                {
                    public string @ref;
                }

                public class BoxBillingId
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class DeviceInfoExtensionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public ExtensionNumber extensionNumber;
                public PartnerId partnerId;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }

                public class PartnerId
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class EmergencyAddressInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public CustomerName customerName;
                public Street street;
                public Street2 street2;
                public City city;
                public State state;
                public Zip zip;
                public Country country;

                public class CustomerName
                {
                    public string type;
                    public string description;
                }

                public class Street
                {
                    public string type;
                    public string description;
                }

                public class Street2
                {
                    public string type;
                    public string description;
                }

                public class City
                {
                    public string type;
                    public string description;
                }

                public class State
                {
                    public string type;
                    public string description;
                }

                public class Zip
                {
                    public string type;
                    public string description;
                }

                public class Country
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Contact contact;
                public Department departments;
                public ExtensionNumber extensionNumber;
                public Name name;
                public PartnerId partnerId;
                public Permission permissions;
                public ProfileImage profileImage;
                public Reference references;
                public RegionalSetting regionalSettings;
                public ServiceFeature serviceFeatures;
                public SetupWizardState setupWizardState;
                public Status status;
                public StatusInfo statusInfo;
                public Type type;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Contact
                {
                    public string @ref;
                }

                public class Department
                {
                    public string @ref;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class PartnerId
                {
                    public string type;
                    public string description;
                }

                public class Permission
                {
                    public string @ref;
                }

                public class ProfileImage
                {
                    public string @ref;
                }

                public class Reference
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class RegionalSetting
                {
                    public string @ref;
                }

                public class ServiceFeature
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class SetupWizardState
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class StatusInfo
                {
                    public string @ref;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class ExtensionInfoRequestContactInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Contact contact;
                public RegionalSetting regionalSettings;
                public SetupWizardState setupWizardState;
                public Department department;

                public class Contact
                {
                    public string @ref;
                }

                public class RegionalSetting
                {
                    public string @ref;
                }

                public class SetupWizardState
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Department
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSetting
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Timezone timezone;
                public Language language;
                public GreetingLanguage greetingLanguage;
                public FormattingLocale formattingLocale;

                public class Timezone
                {
                    public string @ref;
                }

                public class Language
                {
                    public string @ref;
                }

                public class GreetingLanguage
                {
                    public string @ref;
                }

                public class FormattingLocale
                {
                    public string @ref;
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;

                public class Id
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;

                public class Id
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsLanguage
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;

                public class Id
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestContactInfoRegionalSettingsTimezone
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;

                public class Id
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestPartnerId
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PartnerId partnerId;

                public class PartnerId
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestPasswordPin
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Password password;
                public IvrPin ivrPin;

                public class Password
                {
                    public string type;
                    public string description;
                }

                public class IvrPin
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestProvision
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Status status;
                public Contact contact;

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Contact
                {
                    public string @ref;
                }
            }
        }

        public class ExtensionInfoRequestProvisionContactInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public FirstName firstName;
                public LastName lastName;
                public Email email;

                public class FirstName
                {
                    public string type;
                    public string description;
                }

                public class LastName
                {
                    public string type;
                    public string description;
                }

                public class Email
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ExtensionInfoRequestStatusInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Status status;
                public StatusInfo statusInfo;

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class StatusInfo
                {
                    public string @ref;
                }
            }
        }

        public class ExtensionPermission
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Admin admin;
                public InternationalCalling internationalCalling;

                public class Admin
                {
                    public string @ref;
                }

                public class InternationalCalling
                {
                    public string @ref;
                }
            }
        }

        public class ExtensionServiceFeatureInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Enabled enabled;
                public FeatureName featureName;
                public Reason reason;

                public class Enabled
                {
                    public string type;
                    public string description;
                }

                public class FeatureName
                {
                    public string type;
                    public string description;
                }

                public class Reason
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class FormattingLocaleInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public LocaleCode localeCode;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class LocaleCode
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ForwardingInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public NotifyMySoftPhone notifyMySoftPhones;
                public NotifyAdminSoftPhone notifyAdminSoftPhones;
                public SoftPhonesRingCount softPhonesRingCount;
                public RingingMode ringingMode;
                public Rule rules;

                public class NotifyMySoftPhone
                {
                    public string type;
                    public string description;
                }

                public class NotifyAdminSoftPhone
                {
                    public string type;
                    public string description;
                }

                public class SoftPhonesRingCount
                {
                    public string type;
                    public string description;
                }

                public class RingingMode
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Rule
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }
            }
        }

        public class ForwardingNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public PhoneNumber phoneNumber;
                public Label label;
                public Feature features;
                public FlipNumber flipNumber;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class Label
                {
                    public string type;
                    public string description;
                }

                public class Feature
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class FlipNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class FullCountryInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public CallingCode callingCode;
                public EmergencyCalling emergencyCalling;
                public IsoCode isoCode;
                public Name name;
                public NumberSelling numberSelling;
                public LoginAllowed loginAllowed;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class CallingCode
                {
                    public string type;
                    public string description;
                }

                public class EmergencyCalling
                {
                    public string type;
                    public string description;
                }

                public class IsoCode
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class NumberSelling
                {
                    public string type;
                    public string description;
                }

                public class LoginAllowed
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class GrantInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public Extension extension;
                public CallPickup callPickup;
                public CallMonitoring callMonitoring;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Extension
                {
                    public string @ref;
                }

                public class CallPickup
                {
                    public string type;
                    public string description;
                }

                public class CallMonitoring
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class GrantInfoExtensionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public ExtensionNumber extensionNumber;
                public Type type;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class GreetingLanguageInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public LocaleCode localeCode;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class LocaleCode
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class GroupInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public ContactsCount contactsCount;
                public GroupName groupName;
                public Note notes;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ContactsCount
                {
                    public string type;
                    public string description;
                }

                public class GroupName
                {
                    public string type;
                    public string description;
                }

                public class Note
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class LanguageInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Greeting greeting;
                public FormattingLocale formattingLocale;
                public LocaleCode localeCode;
                public Name name;
                public Ui ui;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Greeting
                {
                    public string type;
                    public string description;
                }

                public class FormattingLocale
                {
                    public string type;
                    public string description;
                }

                public class LocaleCode
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class Ui
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class LegInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Action action;
                public Direction direction;
                public Duration duration;
                public Extension extension;
                public LegType legType;
                public StartTime startTime;
                public Type type;
                public Result result;
                public From from;
                public To to;
                public Transport transport;
                public Recording recording;

                public class Action
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Direction
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Duration
                {
                    public string type;
                    public string description;
                }

                public class Extension
                {
                    public string @ref;
                }

                public class LegType
                {
                    public string type;
                    public string description;
                }

                public class StartTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Result
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class From
                {
                    public string @ref;
                }

                public class To
                {
                    public string @ref;
                }

                public class Transport
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Recording
                {
                    public string @ref;
                }
            }
        }

        public class LegInfoExtensionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class LinksInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public StartUri startUri;
                public JoinUri joinUri;

                public class StartUri
                {
                    public string type;
                    public string description;
                }

                public class JoinUri
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class LocationInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public AreaCode areaCode;
                public City city;
                public Npa npa;
                public Nxx nxx;
                public State state;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class AreaCode
                {
                    public string type;
                    public string description;
                }

                public class City
                {
                    public string type;
                    public string description;
                }

                public class Npa
                {
                    public string type;
                    public string description;
                }

                public class Nxx
                {
                    public string type;
                    public string description;
                }

                public class State
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class LookUpPhoneNumberPhoneNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;
                public FormattedNumber formattedNumber;
                public VanityPattern vanityPattern;
                public Rank rank;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class FormattedNumber
                {
                    public string type;
                    public string description;
                }

                public class VanityPattern
                {
                    public string type;
                    public string description;
                }

                public class Rank
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class MeetingInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public Id id;
                public Topic topic;
                public MeetingType meetingType;
                public Password password;
                public Status status;
                public Link links;
                public Schedule schedule;
                public AllowJoinBeforeHost allowJoinBeforeHost;
                public StartHostVideo startHostVideo;
                public StartParticipantsVideo startParticipantsVideo;
                public AudioOption audioOptions;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Topic
                {
                    public string type;
                    public string description;
                }

                public class MeetingType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Password
                {
                    public string type;
                    public string description;
                }

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Link
                {
                    public string @ref;
                }

                public class Schedule
                {
                    public string @ref;
                }

                public class AllowJoinBeforeHost
                {
                    public string type;
                    public string description;
                }

                public class StartHostVideo
                {
                    public string type;
                    public string description;
                }

                public class StartParticipantsVideo
                {
                    public string type;
                    public string description;
                }

                public class AudioOption
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string type;
                    }
                }
            }
        }

        public class MeetingScheduleInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public StartTime startTime;
                public DurationInMinute durationInMinutes;
                public TimeZone timeZone;

                public class StartTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class DurationInMinute
                {
                    public string type;
                    public string description;
                }

                public class TimeZone
                {
                    public string @ref;
                }
            }
        }

        public class MeetingScheduleInfoTimezoneInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;

                public class Id
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class MessageAttachmentInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Type type;
                public ContentType contentType;
                public VmDuration vmDuration;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class ContentType
                {
                    public string type;
                    public string description;
                }

                public class VmDuration
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class MessageInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Attachment attachments;
                public Availability availability;
                public ConversationId conversationId;
                public CreationTime creationTime;
                public DeliveryErrorCode deliveryErrorCode;
                public Direction direction;
                public FaxPageCount faxPageCount;
                public FaxResolution faxResolution;
                public From from;
                public LastModifiedTime lastModifiedTime;
                public MessageStatus messageStatus;
                public PgToDepartment pgToDepartment;
                public Priority priority;
                public ReadStatus readStatus;
                public SmsDeliveryTime smsDeliveryTime;
                public SmsSendingAttemptsCount smsSendingAttemptsCount;
                public Subject subject;
                public To to;
                public Type type;
                public VmTranscriptionStatus vmTranscriptionStatus;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Attachment
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Availability
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class ConversationId
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class CreationTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class DeliveryErrorCode
                {
                    public string type;
                    public string description;
                }

                public class Direction
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class FaxPageCount
                {
                    public string type;
                    public string description;
                }

                public class FaxResolution
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class From
                {
                    public string @ref;
                }

                public class LastModifiedTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class MessageStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class PgToDepartment
                {
                    public string type;
                    public string description;
                }

                public class Priority
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class ReadStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class SmsDeliveryTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class SmsSendingAttemptsCount
                {
                    public string type;
                    public string description;
                }

                public class Subject
                {
                    public string type;
                    public string description;
                }

                public class To
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class VmTranscriptionStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class MessageInfoCallerInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public ExtensionNumber extensionNumber;
                public Location location;
                public MessageStatus messageStatus;
                public FaxErrorCode faxErrorCode;
                public Name name;
                public PhoneNumber phoneNumber;

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }

                public class Location
                {
                    public string type;
                    public string description;
                }

                public class MessageStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class FaxErrorCode
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ModelInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Name name;
                public Addon addons;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class Addon
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }
            }
        }

        public class NavigationInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public FirstPage firstPage;
                public NextPage nextPage;
                public PreviousPage previousPage;
                public LastPage lastPage;

                public class FirstPage
                {
                    public string type;
                    public string description;
                }

                public class NextPage
                {
                    public string type;
                    public string description;
                }

                public class PreviousPage
                {
                    public string type;
                    public string description;
                }

                public class LastPage
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class PagingInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Page page;
                public PerPage perPage;
                public PageStart pageStart;
                public PageEnd pageEnd;
                public TotalPage totalPages;
                public TotalElement totalElements;

                public class Page
                {
                    public string type;
                    public string description;
                }

                public class PerPage
                {
                    public string type;
                    public string description;
                }

                public class PageStart
                {
                    public string type;
                    public string description;
                }

                public class PageEnd
                {
                    public string type;
                    public string description;
                }

                public class TotalPage
                {
                    public string type;
                    public string description;
                }

                public class TotalElement
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ParsePhoneNumberCountryInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public CallingCode callingCode;
                public EmergencyCalling emergencyCalling;
                public IsoCode isoCode;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class CallingCode
                {
                    public string type;
                    public string description;
                }

                public class EmergencyCalling
                {
                    public string type;
                    public string description;
                }

                public class IsoCode
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ParsePhoneNumberPhoneNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public AreaCode areaCode;
                public Country country;
                public Dialable dialable;
                public E164 e164;
                public FormattedInternational formattedInternational;
                public FormattedNational formattedNational;
                public OriginalString originalString;
                public Special special;
                public Normalized normalized;

                public class AreaCode
                {
                    public string type;
                    public string description;
                }

                public class Country
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Dialable
                {
                    public string type;
                    public string description;
                }

                public class E164
                {
                    public string type;
                    public string description;
                }

                public class FormattedInternational
                {
                    public string type;
                    public string description;
                }

                public class FormattedNational
                {
                    public string type;
                    public string description;
                }

                public class OriginalString
                {
                    public string type;
                    public string description;
                }

                public class Special
                {
                    public string type;
                    public string description;
                }

                public class Normalized
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class PermissionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Enabled enabled;

                public class Enabled
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class PersonalContactInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Url url;
                public Availability availability;
                public FirstName firstName;
                public LastName lastName;
                public MiddleName middleName;
                public NickName nickName;
                public Company company;
                public JobTitle jobTitle;
                public HomePhone homePhone;
                public HomePhone2 homePhone2;
                public BusinessPhone businessPhone;
                public BusinessPhone2 businessPhone2;
                public MobilePhone mobilePhone;
                public BusinessFax businessFax;
                public CompanyPhone companyPhone;
                public AssistantPhone assistantPhone;
                public CarPhone carPhone;
                public OtherPhone otherPhone;
                public OtherFax otherFax;
                public CallbackPhone callbackPhone;
                public Email email;
                public Email2 email2;
                public Email3 email3;
                public HomeAddress homeAddress;
                public BusinessAddress businessAddress;
                public OtherAddress otherAddress;
                public Birthday birthday;
                public WebPage webPage;
                public Note notes;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Url
                {
                    public string type;
                    public string description;
                }

                public class Availability
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class FirstName
                {
                    public string type;
                    public string description;
                }

                public class LastName
                {
                    public string type;
                    public string description;
                }

                public class MiddleName
                {
                    public string type;
                    public string description;
                }

                public class NickName
                {
                    public string type;
                    public string description;
                }

                public class Company
                {
                    public string type;
                    public string description;
                }

                public class JobTitle
                {
                    public string type;
                    public string description;
                }

                public class HomePhone
                {
                    public string type;
                    public string description;
                }

                public class HomePhone2
                {
                    public string type;
                    public string description;
                }

                public class BusinessPhone
                {
                    public string type;
                    public string description;
                }

                public class BusinessPhone2
                {
                    public string type;
                    public string description;
                }

                public class MobilePhone
                {
                    public string type;
                    public string description;
                }

                public class BusinessFax
                {
                    public string type;
                    public string description;
                }

                public class CompanyPhone
                {
                    public string type;
                    public string description;
                }

                public class AssistantPhone
                {
                    public string type;
                    public string description;
                }

                public class CarPhone
                {
                    public string type;
                    public string description;
                }

                public class OtherPhone
                {
                    public string type;
                    public string description;
                }

                public class OtherFax
                {
                    public string type;
                    public string description;
                }

                public class CallbackPhone
                {
                    public string type;
                    public string description;
                }

                public class Email
                {
                    public string type;
                    public string description;
                }

                public class Email2
                {
                    public string type;
                    public string description;
                }

                public class Email3
                {
                    public string type;
                    public string description;
                }

                public class HomeAddress
                {
                    public string @ref;
                }

                public class BusinessAddress
                {
                    public string @ref;
                }

                public class OtherAddress
                {
                    public string @ref;
                }

                public class Birthday
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class WebPage
                {
                    public string type;
                    public string description;
                }

                public class Note
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class PhoneLinesInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public LineType lineType;
                public PhoneInfo phoneInfo;

                public class LineType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class PhoneInfo
                {
                    public string @ref;
                }
            }
        }

        public class PhoneLinesInfoPhoneNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Country country;
                public Location location;
                public PaymentType paymentType;
                public PhoneNumber phoneNumber;
                public Status status;
                public Type type;
                public UsageType usageType;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Country
                {
                    public string @ref;
                }

                public class Location
                {
                    public string type;
                    public string description;
                }

                public class PaymentType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class Status
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class UsageType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class PhoneNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Country country;
                public Extension extension;
                public Feature features;
                public Location location;
                public PaymentType paymentType;
                public PhoneNumber phoneNumber;
                public Status status;
                public Type type;
                public UsageType usageType;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Country
                {
                    public string @ref;
                }

                public class Extension
                {
                    public string @ref;
                }

                public class Feature
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string type;
                    }
                }

                public class Location
                {
                    public string type;
                    public string description;
                }

                public class PaymentType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class Status
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class UsageType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class PhoneNumberInfoExtensionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public ExtensionNumber extensionNumber;
                public PartnerId partnerId;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }

                public class PartnerId
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class PresenceInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public AllowSeeMyPresence allowSeeMyPresence;
                public DndStatus dndStatus;
                public Extension extension;
                public Message message;
                public PickUpCallsOnHold pickUpCallsOnHold;
                public PresenceStatus presenceStatus;
                public RingOnMonitoredCall ringOnMonitoredCall;
                public TelephonyStatus telephonyStatus;
                public UserStatus userStatus;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class AllowSeeMyPresence
                {
                    public string type;
                    public string description;
                }

                public class DndStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Extension
                {
                    public string @ref;
                }

                public class Message
                {
                    public string type;
                    public string description;
                }

                public class PickUpCallsOnHold
                {
                    public string type;
                    public string description;
                }

                public class PresenceStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class RingOnMonitoredCall
                {
                    public string type;
                    public string description;
                }

                public class TelephonyStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class UserStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class PresenceInfoExtensionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public ExtensionNumber extensionNumber;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ExtensionNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ProfileImageInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public Etag etag;
                public LastModified lastModified;
                public ContentType contentType;
                public Scale scales;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Etag
                {
                    public string type;
                    public string description;
                }

                public class LastModified
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class ContentType
                {
                    public string type;
                    public string description;
                }

                public class Scale
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string type;
                    }
                }
            }
        }

        public class RangesInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public From from;
                public To to;

                public class From
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class To
                {
                    public string type;
                    public string description;
                    public string format;
                }
            }
        }

        public class RecipientInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public Id id;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Id
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class RecordingInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Type type;
                public ContentUri contentUri;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class ContentUri
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ReferenceInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Ref ref;
                public Type type;

                public class Ref
                {
                    public string type;
                    public string description;
                }

                public class Type
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class RegionalSetting
        {
            public string type;
            public Property properties;

            public class Property
            {
                public HomeCountry homeCountry;
                public Timezone timezone;
                public Language language;
                public GreetingLanguage greetingLanguage;
                public FormattingLocale formattingLocale;

                public class HomeCountry
                {
                    public string @ref;
                }

                public class Timezone
                {
                    public string @ref;
                }

                public class Language
                {
                    public string @ref;
                }

                public class GreetingLanguage
                {
                    public string @ref;
                }

                public class FormattingLocale
                {
                    public string @ref;
                }
            }
        }

        public class ReservePhoneNumberRequestReserveRecord
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;
                public ReservedTill reservedTill;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class ReservedTill
                {
                    public string type;
                    public string description;
                    public string format;
                }
            }
        }

        public class ReservePhoneNumberResponseReserveRecord
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;
                public FormattedNumber formattedNumber;
                public ReservedTill reservedTill;
                public ReservationId reservationId;
                public Status status;
                public Error error;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class FormattedNumber
                {
                    public string type;
                    public string description;
                }

                public class ReservedTill
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class ReservationId
                {
                    public string type;
                    public string description;
                }

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Error
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class RingOutRequestCountryInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;

                public class Id
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class RingOutRequestFrom
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;
                public ForwardingNumberId forwardingNumberId;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class ForwardingNumberId
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class RingOutRequestto
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class RingOutInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Status status;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Status
                {
                    public string @ref;
                }
            }
        }

        public class RingOutStatusInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public CallStatus callStatus;
                public CallerStatus callerStatus;
                public CalleeStatus calleeStatus;

                public class CallStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class CallerStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class CalleeStatus
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class RuleInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Index index;
                public RingCount ringCount;
                public ForwardingNumber forwardingNumbers;

                public class Index
                {
                    public string type;
                    public string description;
                }

                public class RingCount
                {
                    public string type;
                    public string description;
                }

                public class ForwardingNumber
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }
            }
        }

        public class RuleInfoForwardingNumberInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public Id id;
                public PhoneNumber phoneNumber;
                public Label label;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }

                public class Label
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ScheduleInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public WeeklyRange weeklyRanges;
                public Range ranges;
                public Ref ref;

                public class WeeklyRange
                {
                    public string @ref;
                }

                public class Range
                {
                    public string @ref;
                }

                public class Ref
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class ServerInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public ApiVersion apiVersions;
                public ServerVersion serverVersion;
                public ServerRevision serverRevision;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class ApiVersion
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class ServerVersion
                {
                    public string type;
                    public string description;
                }

                public class ServerRevision
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ServiceFeatureInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public FeatureName featureName;
                public Enabled enabled;

                public class FeatureName
                {
                    public string type;
                    public string description;
                }

                public class Enabled
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ServiceInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public BillingPlan billingPlan;
                public Brand brand;
                public ServicePlan servicePlan;
                public TargetServicePlan targetServicePlan;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class BillingPlan
                {
                    public string @ref;
                }

                public class Brand
                {
                    public string @ref;
                }

                public class ServicePlan
                {
                    public string @ref;
                }

                public class TargetServicePlan
                {
                    public string @ref;
                }
            }
        }

        public class ServicePlanInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Name name;
                public Edition edition;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class Edition
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ShippingAddress
        {
            public string type;
            public Property properties;

            public class Property
            {
                public CustomerName customerName;
                public Street street;
                public Street2 street2;
                public City city;
                public State state;
                public Zip zip;
                public Country country;

                public class CustomerName
                {
                    public string type;
                    public string description;
                }

                public class Street
                {
                    public string type;
                    public string description;
                }

                public class Street2
                {
                    public string type;
                    public string description;
                }

                public class City
                {
                    public string type;
                    public string description;
                }

                public class State
                {
                    public string type;
                    public string description;
                }

                public class Zip
                {
                    public string type;
                    public string description;
                }

                public class Country
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class ShippingInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Status status;
                public Carrier carrier;
                public TrackingNumber trackingNumber;
                public Method method;
                public Address address;

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Carrier
                {
                    public string type;
                    public string description;
                }

                public class TrackingNumber
                {
                    public string type;
                    public string description;
                }

                public class Method
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Address
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }
            }
        }

        public class ShippingMethod
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Name
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class StateInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Country country;
                public IsoCode isoCode;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Country
                {
                    public string @ref;
                }

                public class IsoCode
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class StateInfoCountryInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class StatusInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Comment comment;
                public Reason reason;

                public class Comment
                {
                    public string type;
                    public string description;
                }

                public class Reason
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }
            }
        }

        public class SubscriptionRequestDeliveryMode
        {
            public string type;
            public Property properties;

            public class Property
            {
                public TransportType transportType;
                public Encryption encryption;

                public class TransportType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class Encryption
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class SubscriptionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public EventFilter eventFilters;
                public ExpirationTime expirationTime;
                public ExpiresIn expiresIn;
                public Status status;
                public CreationTime creationTime;
                public DeliveryMode deliveryMode;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class EventFilter
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string type;
                    }
                }

                public class ExpirationTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class ExpiresIn
                {
                    public string type;
                    public string description;
                }

                public class Status
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class CreationTime
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class DeliveryMode
                {
                    public string @ref;
                }
            }
        }

        public class SyncInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public SyncType syncType;
                public SyncToken syncToken;
                public SyncTime syncTime;

                public class SyncType
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                }

                public class SyncToken
                {
                    public string type;
                    public string description;
                }

                public class SyncTime
                {
                    public string type;
                    public string description;
                    public string format;
                }
            }
        }

        public class TargetServicePlanInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Name name;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class TimeInterval
        {
            public string type;
            public Property properties;

            public class Property
            {
                public From from;
                public To to;

                public class From
                {
                    public string type;
                    public string description;
                    public string format;
                }

                public class To
                {
                    public string type;
                    public string description;
                    public string format;
                }
            }
        }

        public class TimezoneInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Id id;
                public Uri uri;
                public Name name;
                public Description description;

                public class Id
                {
                    public string type;
                    public string description;
                }

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class Name
                {
                    public string type;
                    public string description;
                }

                public class Description
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class UnconditionalForwardingInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public PhoneNumber phoneNumber;

                public class PhoneNumber
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class VersionInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Uri uri;
                public VersionString versionString;
                public ReleaseDate releaseDate;
                public UriString uriString;

                public class Uri
                {
                    public string type;
                    public string description;
                }

                public class VersionString
                {
                    public string type;
                    public string description;
                }

                public class ReleaseDate
                {
                    public string type;
                    public string description;
                }

                public class UriString
                {
                    public string type;
                    public string description;
                }
            }
        }

        public class VoicemailInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Enabled enabled;
                public Recipient recipient;

                public class Enabled
                {
                    public string type;
                    public string description;
                }

                public class Recipient
                {
                    public string @ref;
                }
            }
        }

        public class WeeklyScheduleInfo
        {
            public string type;
            public Property properties;

            public class Property
            {
                public Monday monday;
                public Tuesday tuesday;
                public Wednesday wednesday;
                public Thursday thursday;
                public Friday friday;
                public Saturday saturday;
                public Sunday sunday;

                public class Monday
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Tuesday
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Wednesday
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Thursday
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Friday
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Saturday
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }

                public class Sunday
                {
                    public string type;
                    public string description;
                    public Item items;

                    public class Item
                    {
                        public string @ref;
                    }
                }
            }
        }
    }

    public class Path
    {
        public Restapi restapi;
        public RestapiOauthAuthorize restapiOauthAuthorize;
        public RestapiOauthRevoke restapiOauthRevoke;
        public RestapiOauthToken restapiOauthToken;
        public RestapiV1_0 restapiV1_0;
        public RestapiV1_0AccountAccountId restapiV1_0AccountAccountId;
        public RestapiV1_0AccountAccountIdActiveCall restapiV1_0AccountAccountIdActiveCalls;
        public RestapiV1_0AccountAccountIdBusinessAddress restapiV1_0AccountAccountIdBusinessAddress;
        public RestapiV1_0AccountAccountIdCallLog restapiV1_0AccountAccountIdCallLog;
        public RestapiV1_0AccountAccountIdCallLogCallLogId restapiV1_0AccountAccountIdCallLogCallLogId;
        public RestapiV1_0AccountAccountIdExtension restapiV1_0AccountAccountIdExtension;
        public RestapiV1_0AccountAccountIdExtensionExtensionId restapiV1_0AccountAccountIdExtensionExtensionId;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdActiveCall restapiV1_0AccountAccountIdExtensionExtensionIdActiveCalls;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdCallLog restapiV1_0AccountAccountIdExtensionExtensionIdCallLog;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdCallLogCallLogId restapiV1_0AccountAccountIdExtensionExtensionIdCallLogCallLogId;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdCompanyPager restapiV1_0AccountAccountIdExtensionExtensionIdCompanyPager;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdFax restapiV1_0AccountAccountIdExtensionExtensionIdFax;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdForwardingNumber restapiV1_0AccountAccountIdExtensionExtensionIdForwardingNumber;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStore restapiV1_0AccountAccountIdExtensionExtensionIdMessageStore;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageId restapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageId;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentId restapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentId;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdPhoneNumber restapiV1_0AccountAccountIdExtensionExtensionIdPhoneNumber;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdPresence restapiV1_0AccountAccountIdExtensionExtensionIdPresence;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdRingout restapiV1_0AccountAccountIdExtensionExtensionIdRingout;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdRingoutRingoutId restapiV1_0AccountAccountIdExtensionExtensionIdRingoutRingoutId;
        public RestapiV1_0AccountAccountIdExtensionExtensionIdSm restapiV1_0AccountAccountIdExtensionExtensionIdSms;
        public RestapiV1_0AccountAccountIdPhoneNumber restapiV1_0AccountAccountIdPhoneNumber;
        public RestapiV1_0AccountAccountIdPhoneNumberPhoneNumberId restapiV1_0AccountAccountIdPhoneNumberPhoneNumberId;
        public RestapiV1_0AccountAccountIdRecordingRecordingId restapiV1_0AccountAccountIdRecordingRecordingId;
        public RestapiV1_0AccountAccountIdRecordingRecordingIdContent restapiV1_0AccountAccountIdRecordingRecordingIdContent;
        public RestapiV1_0DictionaryCountry restapiV1_0DictionaryCountry;
        public RestapiV1_0DictionaryCountryCountryId restapiV1_0DictionaryCountryCountryId;
        public RestapiV1_0DictionaryLanguage restapiV1_0DictionaryLanguage;
        public RestapiV1_0DictionaryLanguageLanguageId restapiV1_0DictionaryLanguageLanguageId;
        public RestapiV1_0DictionaryLocation restapiV1_0DictionaryLocation;
        public RestapiV1_0DictionaryState restapiV1_0DictionaryState;
        public RestapiV1_0DictionaryStateStateId restapiV1_0DictionaryStateStateId;
        public RestapiV1_0DictionaryTimezone restapiV1_0DictionaryTimezone;
        public RestapiV1_0DictionaryTimezoneTimezoneId restapiV1_0DictionaryTimezoneTimezoneId;
        public RestapiV1_0Subscription restapiV1_0Subscription;
        public RestapiV1_0SubscriptionSubscriptionId restapiV1_0SubscriptionSubscriptionId;

        public class Restapi
        {
            public Get get;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }
        }

        public class RestapiOauthAuthorize
        {
            public Post post;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Code code;
                                public ExpiresIn expiresIn;
                                public State state;

                                public class Code
                                {
                                    public string type;
                                    public string description;
                                }

                                public class ExpiresIn
                                {
                                    public string type;
                                    public string description;
                                }

                                public class State
                                {
                                    public string type;
                                    public string description;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public ResponseType responseType;
                            public ClientId clientId;
                            public RedirectUri redirectUri;
                            public State state;

                            public class ResponseType
                            {
                                public string type;
                                public string description;
                            }

                            public class ClientId
                            {
                                public string type;
                                public string description;
                            }

                            public class RedirectUri
                            {
                                public string type;
                                public string description;
                            }

                            public class State
                            {
                                public string type;
                                public string description;
                            }
                        }
                    }
                }
            }
        }

        public class RestapiOauthRevoke
        {
            public Post post;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public Token token;

                            public class Token
                            {
                                public string type;
                                public string description;
                            }
                        }
                    }
                }
            }
        }

        public class RestapiOauthToken
        {
            public Post post;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public AccessToken accessToken;
                                public ExpiresIn expiresIn;
                                public RefreshToken refreshToken;
                                public RefreshTokenExpiresIn refreshTokenExpiresIn;
                                public Scope scope;
                                public TokenType tokenType;
                                public OwnerId ownerId;
                                public EndpointId endpointId;

                                public class AccessToken
                                {
                                    public string type;
                                    public string description;
                                }

                                public class ExpiresIn
                                {
                                    public string type;
                                    public string description;
                                }

                                public class RefreshToken
                                {
                                    public string type;
                                    public string description;
                                }

                                public class RefreshTokenExpiresIn
                                {
                                    public string type;
                                    public string description;
                                }

                                public class Scope
                                {
                                    public string type;
                                    public string description;
                                }

                                public class TokenType
                                {
                                    public string type;
                                    public string description;
                                }

                                public class OwnerId
                                {
                                    public string type;
                                    public string description;
                                }

                                public class EndpointId
                                {
                                    public string type;
                                    public string description;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public GrantType grantType;
                            public AccessTokenTtl accessTokenTtl;
                            public RefreshTokenTtl refreshTokenTtl;
                            public Username username;
                            public Extension extension;
                            public Password password;
                            public Scope scope;
                            public EndpointId endpointId;

                            public class GrantType
                            {
                                public string type;
                                public string description;
                            }

                            public class AccessTokenTtl
                            {
                                public string type;
                                public string description;
                            }

                            public class RefreshTokenTtl
                            {
                                public string type;
                                public string description;
                            }

                            public class Username
                            {
                                public string type;
                                public string description;
                            }

                            public class Extension
                            {
                                public string type;
                                public string description;
                            }

                            public class Password
                            {
                                public string type;
                                public string description;
                            }

                            public class Scope
                            {
                                public string type;
                                public string description;
                            }

                            public class EndpointId
                            {
                                public string type;
                                public string description;
                            }
                        }
                    }
                }
            }
        }

        public class RestapiV1_0
        {
            public Get get;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }
        }

        public class RestapiV1_0AccountAccountId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdActiveCall
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                    public string name;
                    public string @in;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdBusinessAddress
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Uri uri;
                                public Company company;
                                public Email email;
                                public BusinessAddress businessAddress;

                                public class Uri
                                {
                                    public string type;
                                    public string description;
                                }

                                public class Company
                                {
                                    public string type;
                                    public string description;
                                }

                                public class Email
                                {
                                    public string type;
                                    public string description;
                                }

                                public class BusinessAddress
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdCallLog
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                    public string[] @enum;
                    public string format;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdCallLogCallLogId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtension
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                    public string[] @enum;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdActiveCall
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                    public string name;
                    public string @in;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdCallLog
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                    public string[] @enum;
                    public string format;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdCallLogCallLogId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdCompanyPager
        {
            public Post post;
            public Parameter[] parameters;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public From from;
                            public ReplyOn replyOn;
                            public Text text;
                            public To to;

                            public class From
                            {
                                public string @ref;
                            }

                            public class ReplyOn
                            {
                                public string type;
                                public string description;
                            }

                            public class Text
                            {
                                public string type;
                                public string description;
                            }

                            public class To
                            {
                                public string type;
                                public string description;
                                public Item items;

                                public class Item
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdFax
        {
            public Post post;
            public Parameter[] parameters;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public To to;
                            public Resolution resolution;
                            public SendTime sendTime;
                            public CoverIndex coverIndex;
                            public CoverPageText coverPageText;
                            public OriginalMessageId originalMessageId;

                            public class To
                            {
                                public string type;
                                public string description;
                                public Item items;

                                public class Item
                                {
                                    public string @ref;
                                }
                            }

                            public class Resolution
                            {
                                public string type;
                                public string description;
                                public string[] @enum;
                            }

                            public class SendTime
                            {
                                public string type;
                                public string description;
                                public string format;
                            }

                            public class CoverIndex
                            {
                                public string type;
                                public string description;
                            }

                            public class CoverPageText
                            {
                                public string type;
                                public string description;
                            }

                            public class OriginalMessageId
                            {
                                public string type;
                                public string description;
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdForwardingNumber
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStore
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                    public string name;
                    public string @in;
                    public string format;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageId
        {
            public Delete delete;
            public Get get;
            public Put put;
            public Parameter[] parameters;

            public class Delete
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                    public string format;
                }
            }

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Put
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public ReadStatus readStatus;

                            public class ReadStatus
                            {
                                public string type;
                                public string description;
                                public string[] @enum;
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public string format;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdPhoneNumber
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                    public string name;
                    public string @in;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdPresence
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdRingout
        {
            public Post post;
            public Parameter[] parameters;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public From from;
                            public To to;
                            public CallerId callerId;
                            public PlayPrompt playPrompt;
                            public Country country;

                            public class From
                            {
                                public string @ref;
                            }

                            public class To
                            {
                                public string @ref;
                            }

                            public class CallerId
                            {
                                public string @ref;
                            }

                            public class PlayPrompt
                            {
                                public string type;
                                public string description;
                            }

                            public class Country
                            {
                                public string @ref;
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdRingoutRingoutId
        {
            public Delete delete;
            public Get get;
            public Parameter[] parameters;

            public class Delete
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                    }
                }
            }

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdExtensionExtensionIdSm
        {
            public Post post;
            public Parameter[] parameters;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }

                public class Parameter
                {
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public From from;
                            public To to;
                            public Text text;

                            public class From
                            {
                                public string @ref;
                            }

                            public class To
                            {
                                public string type;
                                public string description;
                                public Item items;

                                public class Item
                                {
                                    public string @ref;
                                }
                            }

                            public class Text
                            {
                                public string type;
                                public string description;
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdPhoneNumber
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Paging paging;
                                public Navigation navigation;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                    public string[] @enum;
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdPhoneNumberPhoneNumberId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdRecordingRecordingId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Id id;
                                public ContentUri contentUri;
                                public ContentType contentType;
                                public Duration duration;

                                public class Id
                                {
                                    public string type;
                                    public string description;
                                }

                                public class ContentUri
                                {
                                    public string type;
                                    public string description;
                                }

                                public class ContentType
                                {
                                    public string type;
                                    public string description;
                                }

                                public class Duration
                                {
                                    public string type;
                                    public string description;
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0AccountAccountIdRecordingRecordingIdContent
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public string format;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0DictionaryCountry
        {
            public Get get;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                }
            }
        }

        public class RestapiV1_0DictionaryCountryCountryId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0DictionaryLanguage
        {
            public Get get;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }
            }
        }

        public class RestapiV1_0DictionaryLanguageLanguageId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0DictionaryLocation
        {
            public Get get;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string[] @enum;
                    public string name;
                    public string @in;
                }
            }
        }

        public class RestapiV1_0DictionaryState
        {
            public Get get;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                }
            }
        }

        public class RestapiV1_0DictionaryStateStateId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0DictionaryTimezone
        {
            public Get get;

            public class Get
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string type;
                            public Property properties;

                            public class Property
                            {
                                public Record records;
                                public Navigation navigation;
                                public Paging paging;

                                public class Record
                                {
                                    public string type;
                                    public string description;
                                    public Item items;

                                    public class Item
                                    {
                                        public string @ref;
                                    }
                                }

                                public class Navigation
                                {
                                    public string @ref;
                                }

                                public class Paging
                                {
                                    public string @ref;
                                }
                            }
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                }
            }
        }

        public class RestapiV1_0DictionaryTimezoneTimezoneId
        {
            public Get get;
            public Parameter[] parameters;

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }

        public class RestapiV1_0Subscription
        {
            public Post post;

            public class Post
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public EventFilter eventFilters;
                            public DeliveryMode deliveryMode;

                            public class EventFilter
                            {
                                public string type;
                                public string description;
                                public Item items;

                                public class Item
                                {
                                    public string type;
                                }
                            }

                            public class DeliveryMode
                            {
                                public string @ref;
                            }
                        }
                    }
                }
            }
        }

        public class RestapiV1_0SubscriptionSubscriptionId
        {
            public Delete delete;
            public Get get;
            public Put put;
            public Parameter[] parameters;

            public class Delete
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                    }
                }
            }

            public class Get
            {
                public string description;
                public Response responses;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }
            }

            public class Put
            {
                public string description;
                public Response responses;
                public Parameter[] parameters;

                public class Response
                {
                    public Default @default;

                    public class Default
                    {
                        public string description;
                        public Schema schema;

                        public class Schema
                        {
                            public string @ref;
                        }
                    }
                }

                public class Parameter
                {
                    public string type;
                    public string description;
                    public string name;
                    public string @in;
                    public Schema schema;

                    public class Schema
                    {
                        public string type;
                        public Property properties;

                        public class Property
                        {
                            public EventFilter eventFilters;

                            public class EventFilter
                            {
                                public string type;
                                public string description;
                                public Item items;

                                public class Item
                                {
                                    public string type;
                                }
                            }
                        }
                    }
                }
            }

            public class Parameter
            {
                public string @ref;
            }
        }
    }
}