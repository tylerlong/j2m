# j2m

`j2m` is short for `Json to Model`.

Generate model according to json data.
Why? Once you have the model, you can deserialize json to model.

You can specify either a json file or multiple json files or a folder which contains one or more json files as input.
Multiple json files will be deep-merged into one json file before processing.


## todo

1. auto test upon saving
    1. gulp
1. best practice to write documentation
1. TypeScript
1. allow user to specify template


## Installation

```shell
npm install json2model
```


## Usage


### Command line

Generate `account` model in C#:

Specify a folder which contains json files for model `account`:

```shell
j2m -l cs -n account -f test/fixtures/json/account/
```

Specify a json file which is the definition for model `account`:

```shell
j2m -l cs -n account -j test/fixtures/json/account/130829004.json
```


### Node.js

```javascript
const JsonHelper = require('json2model/helpers/json');
const json = JsonHelper.readFile('account.json');
// Or read multiple json files: const json = JsonHelper.readFiles(['account1.json', 'account2.json']);
// Or read from folder: const json = JsonHelper.readFolder('./account/');
const LanguageController = require('json2model/controllers/cs'); // language is C#
const model = LanguageController.render('account', json); // model name is "account"
console.log(model);
```


## Example

### `account.json`:

```json
{
  "uri" : "https://platform.devtest.ringcentral.com/restapi/v1.0/account/130829004",
  "id" : 130829004,
  "serviceInfo" : {
    "uri" : "https://platform.devtest.ringcentral.com/restapi/v1.0/account/130829004/service-info",
    "brand" : {
      "id" : "1210",
      "name" : "RingCentral",
      "homeCountry" : {
        "id" : "1",
        "uri" : "https://platform.devtest.ringcentral.com/restapi/v1.0/dictionary/country/1",
        "name" : "United States",
        "isoCode" : "US",
        "callingCode" : "1"
      }
    },
    "servicePlan" : {
      "id" : "4499",
      "name" : "Sandbox Office 4 lines Enterprise Edition",
      "edition" : "Enterprise"
    },
    "billingPlan" : {
      "id" : "8853",
      "name" : "Monthly-109.98-Sandbox 4 Line",
      "durationUnit" : "Month",
      "duration" : 1,
      "type" : "Regular"
    }
  },
  "operator" : {
    "uri" : "https://platform.devtest.ringcentral.com/restapi/v1.0/account/130829004/extension/130829004",
    "id" : 130829004,
    "extensionNumber" : "101"
  },
  "mainNumber" : "+17322764403",
  "status" : "Confirmed",
  "signupInfo" : { },
  "setupWizardState" : "Completed"
}
```


### Generated C# model:

```csharp
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
```


### Usage of generated model

```csharp
using Newtonsoft.Json;

var content = File.ReadAllText("account.json");
var account = JsonConvert.DeserilizeObject<Account>(content);
```


## Supported languages

- C#
