# [ThrowExtensions Class](help/html/T_EgonsoftHU_Extensions_Bcl_ThrowExtensions.htm)

Back to [Package Contents](https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl#package-contents)

Instead of
```C#
void DoSomething<T>(T foo, string bar, Guid baz, int qux) where T : class
{
    if (foo is null)
    {
        throw new ArgumentNullException(nameof(foo));
    }

    if (String.IsNullOrEmpty(bar))
    {
        throw new ArgumentNullException(nameof(bar));
    }

    if (Guid.Empty == baz)
    {
        throw new ArgumentNullException(nameof(baz));
    }

    if (qux <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(qux));
    }
}
```
you can write
```C#
using EgonsoftHU.Extensions.Bcl;

void DoSomething<T>(T foo, string bar, int? baz, Guid? qux, Guid quux, int quuz) where T : class
{
    // These methods use CallerArgumentExpressionAttribute
    // (introduced in C# 10 / .NET 6)
    //
    // This nuget package contains this as an internal attribute
    // for target frameworks other than net6.0
    // so that the compiler can make use of it.
    //
    // Tested also with a Non-SDK-style project that targets net461:

    foo.ThrowIfNull();

    bar.ThrowIfNull();
    bar.ThrowIfNullOrEmpty();
    bar.ThrowIfNullOrWhiteSpace();

    baz.ThrowIfNull();

    qux.ThrowIfNull();
    qux.ThrowIfEmptyGuid();

    quux.ThrowIfEmptyGuid();

    quuz.ThrowIfZero();
    quuz.ThrowIfNegative();
    quuz.ThrowIfNegativeOrZero();
    quuz.ThrowIfPositive();
    quuz.ThrowIfPositiveOrZero();
    quuz.ThrowIfEqualTo(0);
    quuz.ThrowIfNotEqualTo(0);
    quuz.ThrowIfLessThan(0);
    quuz.ThrowIfLessThanOrEqualTo(0);
    quuz.ThrowIfGreaterThan(0);
    quuz.ThrowIfGreaterThanOrEqualTo(0);

    // If the ArgumentNullException.ParamName property remains unset
    // (i.e. the compiler you use does not support this attribute yet)
    // then specify the parameter name this way:

    foo.ThrowIfNull(nameof(foo));

    bar.ThrowIfNull(nameof(bar));
    bar.ThrowIfNullOrEmpty(nameof(bar));
    bar.ThrowIfNullOrWhiteSpace(nameof(bar));

    baz.ThrowIfNull(nameof(baz));

    qux.ThrowIfNull(nameof(qux));
    qux.ThrowIfEmptyGuid(nameof(qux));

    quux.ThrowIfEmptyGuid(nameof(quux));
}
```

