# Model Generator

Generate models according to json data.


## todo

1. `var` => `let` / `const`


## Usage

Generate `account` model in C#:

```shell
node mg.js cs -m account
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
