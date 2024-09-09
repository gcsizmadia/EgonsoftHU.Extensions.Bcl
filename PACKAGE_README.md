# Egonsoft.HU BCL Extensions

C# extension methods for Base Class Library types.

## Summary

- Extension methods for throwing `ArgumentNullException`
- Extension methods for throwing `ArgumentException`
- Extension methods for throwing `ArgumentOutOfRangeException`
- Extension methods for specific types
- Extension methods with generic type parameters
- Predefined (`const` / `readonly`) values
- More information

## Extension methods for throwing `ArgumentNullException` or `ArgumentException`

- For generic `T` type:
  - `ThrowIfNull<T>()` throws `ArgumentNullException`
- For `System.String` type:
  - `ThrowIfNullOrEmpty()` throws `ArgumentNullException` or `ArgumentException`
  - `ThrowIfNullOrWhiteSpace()` throws `ArgumentNullException` or `ArgumentException`
- For `System.Guid` type:
  - `ThrowIfEmptyGuid()` throws `ArgumentException`

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
  - `AddRange()`
- `System.Collections.Generic.IDictionary<TKey, TValue>`
  - `AsReadOnly()`
  - `AsSorted()`
  - `DefaultIfKeyNotFound()`
  - `GetOrThrow()`
- `System.Collections.Generic.IEnumerable<T>`
  - `IsNullOrEmpty()`
  - `DetectChanges()` - Get new, existing and removed items.
- `System.Collections.Generic.IList<T>`
  - `AsReadOnly()` up to .NET 6 (An extension method with the same signature is part of .NET 7+.)
- `System.DateOnly`
  - `IsInRange()`
- `System.DateTime`
  - `IsInRange()`
  - `ToMinutePrecision()`
  - `ToSecondPrecision()`
- `System.DateTimeOffset`
  - `IsInRange()`
  - `ToMinutePrecision()`
  - `ToSecondPrecision()`
- `System.Exception`
  - `GetHttpStatusCode()`
  - `SetHttpStatusCode()`
- `System.IO.Stream`
  - `ToByteArray()`
  - `ToByteArrayAsync()`
  - `TryResetStreamPosition()`
- `System.Reflection.Assembly`
- `System.Reflection.MemberInfo`
- `System.Reflection.ParameterInfo`
- `System.String`
  - `IsNullOrEmpty()`
  - `IsNullOrWhiteSpace()`
  - `DefaultIfNullOrEmpty()`
  - `DefaultIfNullOrWhiteSpace()`
  - `EnsureTrailingSlash()`
  - `EnsureNoTrailingSlash()`
- `System.Type`
  - `AsNullableValueType()`
  - `IsNullableValueType()`
- Numeric types:  
  `System.SByte`, `System.Int16`, `System.Int32`, `System.Int64`,  
  `System.Byte`, `System.UInt16`, `System.UInt32`, `System.UInt64`,  
  `System.Half`, `System.Single`, `System.Double`, `System.Decimal`
  - `IsZero()`
  - `IsNegative()`
  - `IsNegativeOrZero()`
  - `IsPositive()`
  - `IsPositiveOrZero()`
  - `IsInRange()`

## Extension methods with generic type parameters

- `IEnumerable`-related
  - `AsSingleElementSequence()`
  - `IsIn()`
  - `IsNotIn()`
- `Reflection`-related
  - `GetPropertyValue()`
  - `TryPropertyValue()`
  - `SetPropertyValue()`
  - `TrySetPropertyValue()`
- value selectors
  - `GetStringValueOrNull()`
  - `GetStringValueOrEmptyString()`
  - `GetValueOrDefault()`
  - `GetValue()`

## Predefined (`const` / `readonly`) values

- `Chars`
- `DateTimeFormats`
- `GenericTypeDefinitions`
- `GuidFormats`
- `HttpStatusCodes`
- `Strings`

## `enum` types

- `IntervalBoundsOptions` - can be used in the new `IsInRange()` extension methods.

## Other types

- `EnumInfo<TEnum>`
  - A wrapper class that provides additional information about an `enum` type or value.
    - The custom attributes applied to a member.
    - Easy access to the list of the defined members.
    - Easy access to the name or the underlying value of a member.
    - Support for customizing the serialized value through attributes.
    - Implements bitwise / comparison / implicit conversion / equality operators.
- `EncodingProvider`
  - `UTF8WithoutBOM` The UTF-8 encoding without the Unicode byte order mark.
- `StringSyntaxAttribute`
  -  up to .NET 6 (This attribute is part of .NET 7+.)
- `StructuralEqualityComparer<T>`
  - Provides a generic `IEqualityComparer<T>` instance for using the non-generic `System.Collections.StructuralComparisons.StructuralEqualityComparer`.
- `TypeHelper`
  - `GetName<T>()` / `GetName(Type)` methods as a shortcut for `Type.FullName ?? Type.Name` expression.

## More information

Learn more at [https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl](https://github.com/gcsizmadia/EgonsoftHU.Extensions.Bcl)
