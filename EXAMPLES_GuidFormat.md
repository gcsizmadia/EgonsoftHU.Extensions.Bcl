# [GuidFormat Class](help/T_EgonsoftHU_Extensions_Bcl_Constants_GuidFormat.md)

Back to [Package Contents](https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl#package-contents)

You can use this class for parsing and formatting [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid?view=net-6.0) values.

Let's see an example using Dynamics 365 API:

```C#
using System;

string apiRoot = "/api/data/v9.0/";
string entitySetName = "incidents";
var entityId = Guid.NewGuid();

// The example API endpoint:
// /api/data/v9.0/incidents(incidentid)

// Instead of manually enclosing the Guid value in parentheses
// we can specify that format for parsing and formatting methods.
```

## ToString()

```C#
using EgonsoftHU.Extensions.Bcl.Constants;

// Instead of
string formattedEntityId = entityId.ToString("P");
// you can write
string formattedEntityId = entityId.ToString(GuidFormat.Parenthesis);

string entityUrlReference = $"{apiRoot}{entitySetName}{formattedEntityId}";
```

## ParseExact()

```C#
using EgonsoftHU.Extensions.Bcl.Constants;

// Instead of
Guid entityId = Guid.ParseExact(formattedEntityId, "P");
// you can write
Guid entityId = Guid.ParseExact(formattedEntityId, GuidFormat.Parenthesis);
```

## TryParseExact()

```C#
using EgonsoftHU.Extensions.Bcl.Constants;

// Instead of
if (Guid.TryParseExact(formattedEntityId, "P", out Guid entityId))
{
}
// you can write
if (Guid.TryParseExact(formattedEntityId, GuidFormat.Parenthesis, out Guid entityId)
{
}
```

## Converting from one format to another format

```C#
using EgonsoftHU.Extensions.Bcl.Constants;

string input = Guid.NewGuid().ToString(GuidFormat.Brace);
// e.g. {72802294-8a43-4ba9-a360-3498df3cb0c7}

string output = ChangeGuidFormat(input, GuidFormat.Brace, GuidFormat.Parenthesis);
// e.g. (72802294-8a43-4ba9-a360-3498df3cb0c7)

string ChangeGuidFormat(string input, string inputFormat, string outputFormat)
{
    return
        Guid.TryParseExact(input, inputFormat, out Guid value)
            ? value.ToString(outputFormat)
            : throw new ArgumentException("Error parsing the Guid value.", nameof(input));
}
```
