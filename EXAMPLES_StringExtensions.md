# [StringExtensions Class](help/html/T_EgonsoftHU_Extensions_Bcl_StringExtensions.htm)

Back to [Package Contents](https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl#package-contents)

Instead of
```C#
string value = "foo";

if (String.IsNullOrEmpty(value))
{
}

if (String.IsNullOrWhiteSpace(value))
{
}
```
you can write
```C#
using EgonsoftHU.Extensions.Bcl;

string value = "foo";

if (value.IsNullOrEmpty())
{
}

if (value.IsNullOrWhiteSpace())
{
}
```

Also instead of
```C#
void DoSomething(string? input)
{
    const string DefaultValue = "Unknown";

    string value1 =
        String.IsNullOrEmpty(input) ? DefaultValue : input;

    string value2 =
        String.IsNullOrWhiteSpace(input) ? DefaultValue : input;
}
```
you can write
```C#
void DoSomething(string? input)
{
    const string DefaultValue = "Unknown";

    string value1 = input.DefaultIfNullOrEmpty(DefaultValue);

    string value2 = input.DefaultIfNullOrWhiteSpace(DefaultValue);
}
```
