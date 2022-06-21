# [GenericExtensions Class](help/T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md)

Back to [Package Contents](https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl#package-contents)

## AsEnumerable()

Suppose you have a method that expects an instance of `IEnumerable<int>` type but you have only a single `int` variable.
```C#
int x = 42;

void Process(IEnumerable<int> numbers)
{
}
```
Instead of
```C#
Process(new int[] { x });
```
you can write
```C#
Process(x.AsEnumerable());
```

## IsIn()

Suppose you want to check if a value matches only some specific members of an `Enum` type.

Instead of
```C#
bool IsWeekend(DateTime date)
{
    return
        date.DayOfWeek == DateOfWeek.Saturday ||
        date.DayOfWeek == DateOfWeek.Sunday;
}
```
you can write
```C#
using EgonsoftHU.Extensions.Bcl;

bool IsWeekend(DateTime date)
{
    return date.DayOfWeek.IsIn(DateOfWeek.Saturday, DateOfWeek.Sunday);
}
```
Suppose you want to check if a `string` value matches some specific values regardless of their casing.

Instead of
```C#
const string Development = nameof(Development);
const string Staging = nameof(Staging);

bool IsNonProductionEnvironment(string environment)
{
    environment = environment?.ToLower();

    return
        Development.ToLower() == environment ||
        Staging.ToLower() == environment;
}
```
you can write
```C#
using EgonsoftHU.Extensions.Bcl;

const string Development = nameof(Development);
const string Staging = nameof(Staging);

bool IsNonProductionEnvironment(string environment)
{
    return
        environment.IsIn(
            StringComparer.OrdinalIgnoreCase,
            Development,
            Staging
        );
}
```

