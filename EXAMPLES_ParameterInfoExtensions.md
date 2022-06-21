# [ParameterInfoExtensions Class](help/T_EgonsoftHU_Extensions_Bcl_ParameterInfoExtensions.md)

Back to [Package Contents](https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl#package-contents)

## Is&lt;T&gt;(string)

Suppose you expect a specific parameter type and name.

Instead of
```C#
void Process(ParameterInfo parameter)
{
    if (
        parameter != null
        &&
        parameter.ParameterType == typeof(string)
        &&
        String.Equals(parameter.Name, "foo", StringComparison.Ordinal)
    )
    {
    }
}
```
you can write
```C#
void Process(ParameterInfo parameter)
{
    if (parameter.Is<string>("foo"))
    {
    }
}
```
E.g. you want `Autofac` to automatically inject an instance of `Serilog.ILogger` that is specific to the target class and also you want to enforce the following convention for that constructor parameter:
- The name must be `logger`.
```C#
using Autofac;
using EgonsoftHU.Extensions.Bcl;
using Serilog;

var resolvedParameter =
    new ResolvedParameter(
        (parameter, context) => parameter.Is<ILogger>("logger"),
        (parameter, context) => Log.Logger.ForContext(parameter.Member.DeclaringType)
    );
```
