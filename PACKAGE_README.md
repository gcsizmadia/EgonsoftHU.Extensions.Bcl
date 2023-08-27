# Egonsoft.HU BCL Extensions

C# extension methods for Base Class Library types.

## Summary

- Extension methods for throwing `ArgumentNullException`
- Extension methods for throwing `ArgumentOutOfRangeException`
- Extension methods for specific types
- Extension methods with generic type parameters
- Predefined (`const` / `readonly`) values
- More information

## Extension methods for throwing `ArgumentNullException`

- For generic `T` type:
  - `ThrowIfNull<T>()`
- For `System.String` type:
  - `ThrowIfNullOrEmpty()`
  - `ThrowIfNullOrWhiteSpace()`
- For `System.Guid` type:
  - `ThrowIfEmptyGuid()`

## Extension methods for throwing `ArgumentOutOfRangeException`

Can't wait for the new static methods in `ArgumentOutOfRangeException` that will be introduced in **.NET 8**?  
In this package they are available as extension methods.

- For `IEquatable<T>` type:
  - `ThrowIfEqualTo()`
  - `ThrowIfNotEqualTo()`
- For `IComparable<T>` type:
  - `ThrowIfLessThan()`
  - `ThrowIfLessThanOrEqualTo()`
  - `ThrowIfGreaterThan`
  - `ThrowIfGreaterThanOrEqualTo()`
- For numeric types:  
  `System.SByte`, `System.Int16`, `System.Int32`, `System.Int64`,  
  `System.Byte`, `System.UInt16`, `System.UInt32`, `System.UInt64`,  
  `System.Half`, `System.Single`, `System.Double`, `System.Decimal`
  - `ThrowIfZero()`
  - `ThrowIfNegative()`
  - `ThrowIfNegativeOrZero()`
  - `ThrowIfPositive()`
  - `ThrowIfPositiveOrZero()`

## Extension methods for specific types

This package contains extension methods for these types:

- `System.Collections.Generic.ICollection<T>`
- `System.Collections.Generic.IDictionary<TKey, TValue>`
- `System.Collections.Generic.IEnumerable<T>`
- `System.DateTimeOffset`
- `System.IO.Stream`
- `System.Reflection.Assembly`
- `System.Reflection.MemberInfo`
- `System.Reflection.ParameterInfo`
- `System.String`
- `System.Type`
- Numeric types:  
  `System.SByte`, `System.Int16`, `System.Int32`, `System.Int64`,  
  `System.Byte`, `System.UInt16`, `System.UInt32`, `System.UInt64`,  
  `System.Half`, `System.Single`, `System.Double`, `System.Decimal`

## Extension methods with generic type parameters

- `IEnumerable`-related
- `Reflection`-related
- value selectors

## Predefined (`const` / `readonly`) values

- `GuidFormat`
- `GenericTypeDefinitions`

## More information

Learn more at [https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl](https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl)
