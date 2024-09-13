# EnumInfo&lt;TEnum&gt; Class


A base class to represent an enumeration value and also to provide access to additional information about both the current enumeration value and the *TEnum* type itself.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public abstract class EnumInfo<TEnum> : EnumInfo, 
	IComparable<EnumInfo<TEnum>>, IComparable, IEnumerable<EnumInfo<TEnum>>, 
	IEnumerable, IEquatable<EnumInfo<TEnum>>
where TEnum : struct, new()

```
**VB**
``` VB
Public MustInherit Class EnumInfo(Of TEnum As {Structure, New})
	Inherits EnumInfo
	Implements IComparable(Of EnumInfo(Of TEnum)), 
	IComparable, IEnumerable(Of EnumInfo(Of TEnum)), IEnumerable, 
	IEquatable(Of EnumInfo(Of TEnum))
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo.md">EnumInfo</a>  →  EnumInfo(TEnum)</td></tr>
<tr><td><strong>Implements</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(EnumInfo(TEnum)), <a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" target="_blank" rel="noopener noreferrer">IEnumerable</a>, <a href="https://learn.microsoft.com/dotnet/api/system.icomparable" target="_blank" rel="noopener noreferrer">IComparable</a>, <a href="https://learn.microsoft.com/dotnet/api/system.icomparable-1" target="_blank" rel="noopener noreferrer">IComparable</a>(EnumInfo(TEnum)), <a href="https://learn.microsoft.com/dotnet/api/system.iequatable-1" target="_blank" rel="noopener noreferrer">IEquatable</a>(EnumInfo(TEnum))</td></tr>
</table>



#### Type Parameters
<dl><dt /><dd>The type of the enumeration.</dd></dl>

## Properties
<table>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Attributes.md">Attributes</a></td>
<td>Gets all custom attributes applied to the current member of the <em>TEnum</em> type.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_DeclaredMembers.md">DeclaredMembers</a></td>
<td>Gets a collection of the fields defined by the <em>TEnum</em> type, each represented by an instance of the EnumInfo(TEnum) type.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_DeclaredMembersExcludingSynonyms.md">DeclaredMembersExcludingSynonyms</a></td>
<td>Gets a collection of the fields defined by the <em>TEnum</em> type, each represented by an instance of the EnumInfo(TEnum) type.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Default.md">Default</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents the value of <a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_DefaultValue.md">DefaultValue</a> property.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_DefaultValue.md">DefaultValue</a></td>
<td>Gets the value produced by the expression <code>(TEnum)0</code>, where <em>TEnum</em> is the enum identifier.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_IsDefaultValue.md">IsDefaultValue</a></td>
<td>Indicates whether the current enumeration value is the default value of the <em>TEnum</em> type.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_IsDefined.md">IsDefined</a></td>
<td>Indicates whether the current enumeration value is defined in the <em>TEnum</em> type.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Name.md">Name</a></td>
<td>Gets the name of the constant in the <em>TEnum</em> type for the current enumeration value.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_SerializedValue.md">SerializedValue</a></td>
<td>Gets a string representation of the current enumeration value.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_UInt64Value.md">UInt64Value</a></td>
<td>Gets the value of the underlying type constant in the <em>TEnum</em> type converted to <a href="https://learn.microsoft.com/dotnet/api/system.uint64" target="_blank" rel="noopener noreferrer">UInt64</a>.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Value.md">Value</a></td>
<td>Gets the value of the constant in the <em>TEnum</em> type for the current enumeration value.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_CompareTo.md">CompareTo(EnumInfo(TEnum))</a></td>
<td>Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_CompareTo_1.md">CompareTo(Object)</a></td>
<td>Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Equals.md">Equals(EnumInfo(TEnum))</a></td>
<td>Indicates whether the current object is equal to another object of the same type.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Equals_2.md">Equals(Object)</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Overrides <a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Object.Equals(Object)</a>)</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Equals_1.md">Equals(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Determines whether the specified EnumInfo(TEnum) instances are considered equal.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromName.md">FromName</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type that have the specified <em>name</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue.md">FromUnderlyingValue(Byte)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue_1.md">FromUnderlyingValue(Int16)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue_2.md">FromUnderlyingValue(Int32)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue_3.md">FromUnderlyingValue(Int64)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue_4.md">FromUnderlyingValue(SByte)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue_5.md">FromUnderlyingValue(UInt16)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue_6.md">FromUnderlyingValue(UInt32)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromUnderlyingValue_7.md">FromUnderlyingValue(UInt64)</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromValue.md">FromValue</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the value of which equals to the specified <em>value</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_GetEnumerator.md">GetEnumerator</a></td>
<td>Returns an enumerator that iterates through the collection.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_GetHashCode.md">GetHashCode</a></td>
<td>Serves as the default hash function.<br />(Overrides <a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode" target="_blank" rel="noopener noreferrer">Object.GetHashCode()</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_HasFlag.md">HasFlag</a></td>
<td>Determines whether one or more bit fields are set in the current instance.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromName.md">TryFromName</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type that have the specified <em>name</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue.md">TryFromUnderlyingValue(Byte, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue_1.md">TryFromUnderlyingValue(Int16, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue_2.md">TryFromUnderlyingValue(Int32, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue_3.md">TryFromUnderlyingValue(Int64, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue_4.md">TryFromUnderlyingValue(SByte, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue_5.md">TryFromUnderlyingValue(UInt16, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue_6.md">TryFromUnderlyingValue(UInt32, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromUnderlyingValue_7.md">TryFromUnderlyingValue(UInt64, EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the underlying value of which equals to the specified <em>underlyingValue</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_TryFromValue.md">TryFromValue</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents one or more constants in the <em>TEnum</em> type the value of which equals to the specified <em>value</em>.</td></tr>
</table>

## Operators
<table>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_BitwiseAnd.md">BitwiseAnd(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Computes the bitwise logical AND of the <em>left</em> and <em>right</em> operands.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_BitwiseOr.md">BitwiseOr(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Computes the bitwise logical OR of the <em>left</em> and <em>right</em> operands.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_Equality.md">Equality(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Indicates whether the <em>left</em> parameter is equal to the <em>right</em> parameter.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_ExclusiveOr.md">ExclusiveOr(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Computes the bitwise logical exclusive OR, also known as the bitwise logical XOR, of the <em>left</em> and <em>right</em> operands.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_GreaterThan.md">GreaterThan(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Indicates whether the <em>left</em> parameter is greater than the <em>right</em> parameter.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_GreaterThanOrEqual.md">GreaterThanOrEqual(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Indicates whether the <em>left</em> parameter is greater than or equal to the <em>right</em> parameter.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_Implicit_1.md">Implicit(TEnum to EnumInfo(TEnum))</a></td>
<td>Gets an instance of the EnumInfo(TEnum) type that represents the specified <em>value</em>.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_Implicit.md">Implicit(EnumInfo(TEnum) to TEnum)</a></td>
<td>Defines an implicit conversion of an instance of the EnumInfo(TEnum) type to its underlying enum value.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_Inequality.md">Inequality(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Indicates whether the <em>left</em> parameter is not equal to the <em>right</em> parameter.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_LessThan.md">LessThan(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Indicates whether the <em>left</em> parameter is less than the <em>right</em> parameter.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_LessThanOrEqual.md">LessThanOrEqual(EnumInfo(TEnum), EnumInfo(TEnum))</a></td>
<td>Indicates whether the <em>left</em> parameter is less than or equal to the <em>right</em> parameter.</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_OnesComplement.md">OnesComplement(EnumInfo(TEnum))</a></td>
<td>Computes the bitwise complement of the specified <em>value</em>.</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_EnumType.md">EnumType</a></td>
<td>The type of the enumeration specified by the <em>TEnum</em> type parameter.</td></tr>
<tr>
<td><a href="F_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_EnumTypeCode.md">EnumTypeCode</a></td>
<td>The underlying type code of the enumeration specified by the <em>TEnum</em> type parameter.</td></tr>
<tr>
<td><a href="F_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_EnumTypeInfo.md">EnumTypeInfo</a></td>
<td>The <a href="https://learn.microsoft.com/dotnet/api/system.reflection.typeinfo" target="_blank" rel="noopener noreferrer">TypeInfo</a> representation of the type stored in the <a href="F_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_EnumType.md">EnumType</a> field.</td></tr>
<tr>
<td><a href="F_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_EnumUnderlyingType.md">EnumUnderlyingType</a></td>
<td>The underlying type of the enumeration specified by the <em>TEnum</em> type parameter.</td></tr>
<tr>
<td><a href="F_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_HasFlagsAttribute.md">HasFlagsAttribute</a></td>
<td>Indicates whether the <a href="https://learn.microsoft.com/dotnet/api/system.flagsattribute" target="_blank" rel="noopener noreferrer">FlagsAttribute</a> is applied to the enumeration type specified by the <em>TEnum</em> type parameter.</td></tr>
<tr>
<td><a href="F_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_IsSigned.md">IsSigned</a></td>
<td>Indicates whether the underlying type is a signed integral numeric type.</td></tr>
</table>

## Extension Methods
<table>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_IEnumerableExtensions_DetectChanges__2.md">DetectChanges(EnumInfo(TEnum), TKey)</a></td>
<td>Groups the difference between <em>incomingItems</em> and <em>existingItems</em> into new, existing and removed items according to a specified key selector function.<br />(Defined by <a href="T_EgonsoftHU_Extensions_Bcl_IEnumerableExtensions.md">IEnumerableExtensions</a>)</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_IEnumerableExtensions_IsNullOrEmpty__1.md">IsNullOrEmpty(EnumInfo(TEnum))</a></td>
<td>Determines whether a sequence is null or contains no element.<br />(Defined by <a href="T_EgonsoftHU_Extensions_Bcl_IEnumerableExtensions.md">IEnumerableExtensions</a>)</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_ThrowExtensions_ThrowIfNullOrEmpty__1.md">ThrowIfNullOrEmpty(EnumInfo(TEnum))</a></td>
<td>Throws an exception if <em>param</em> is null or the sequence contains no element.<br />(Defined by <a href="T_EgonsoftHU_Extensions_Bcl_ThrowExtensions.md">ThrowExtensions</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  
