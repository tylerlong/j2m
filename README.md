# j2m

`j2m` is short for `Json to Model`.

Generate model according to json data.
Why? Once you have the model, you can deserialize json to model.

You can specify either one or multiple json files as input.
Multiple json files will be deep-merged into one json file before processing.


## todo

1. editor/ide auto format code?
1. support C# namespace
1. auto generate test case
    1. deserialize and compare the values
1. check style according to http://es6.ruanyifeng.com/#docs/


## Installation

```shell
npm install j2m
```


## Usage

Generate `account` model in C#:

```shell
j2m cs -m account
```


## Example

### `user.json`:

```json
{
  "firstName": "Tyler",
  "lastName": "Long",
  "emails": ["aaa@example.com", "bbb@example.com"],
  "projects":[
    {
      "name": "C# SDK",
      "budget": "$100"
    },
    {
      "name": "C# Client",
      "budget": "$200"
    }
  ]
}
```

### Generated C# model:

```csharp
public partial class User
{
  public string firstName;
  public string lastName;
  public string[] emails;
  public Project[] projects;

  public class Project
  {
    public string name;
    public string budget;
  }
}
```

### Usage of generated model

```csharp
using Newtonsoft.Json;

var content = File.ReadAllText("user.json");
var user = JsonConvert.DeserilizeObject<User>(content);
```


## Other languages

This project starts with C#. Other languages are in the todo list.
