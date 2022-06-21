# [StringExtensions Class](help/T_EgonsoftHU_Extensions_Bcl_StringExtensions.md)

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
