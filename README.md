# j2m

`j2m` is short for `Json to Model`.

Generate model according to json data.
Why? Once you have the model, you can deserialize json to model.

You can specify either a json file or a folder which contains json files as input.
Multiple json files inside folder will be deep-merged into one json file before processing.


## todo

1. auto generate test case
    1. deserialize and compare the values
1. check style according to http://es6.ruanyifeng.com/#docs/
1. auto test upon saving
1. best practice to write documentation
1. code coverage


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
const json = JsonHelper.readFile('account.json') // Or read from folder: const json = JsonHelper.readFolder('./account/');
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
    public string uri;
    public int? id;
    public ServiceInfo serviceInfo;
    public Operator @operator;
    public string mainNumber;
    public string status;
    public SignupInfo signupInfo;
    public string setupWizardState;

    public class ServiceInfo
    {
        public string uri;
        public Brand brand;
        public ServicePlan servicePlan;
        public BillingPlan billingPlan;

        public class Brand
        {
            public string id;
            public string name;
            public HomeCountry homeCountry;

            public class HomeCountry
            {
                public string id;
                public string uri;
                public string name;
                public string isoCode;
                public string callingCode;
            }
        }

        public class ServicePlan
        {
            public string id;
            public string name;
            public string edition;
        }

        public class BillingPlan
        {
            public string id;
            public string name;
            public string durationUnit;
            public int? duration;
            public string type;
        }
    }

    public class Operator
    {
        public string uri;
        public int? id;
        public string extensionNumber;
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
