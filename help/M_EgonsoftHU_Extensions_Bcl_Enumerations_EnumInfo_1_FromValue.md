# FromValue Method


Gets an instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents one or more constants in the *TEnum* type the value of which equals to the specified *value*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static EnumInfo<TEnum> FromValue(
	TEnum value
)
```
**VB**
``` VB
Public Shared Function FromValue ( 
	value As TEnum
) As EnumInfo(Of TEnum)
```



#### Parameters
<dl><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a></dt><dd>An enumeration value.</dd></dl>

#### Return Value
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a>)  
An instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents the constant(s) in the *TEnum* type.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.notsupportedexception" target="_blank" rel="noopener noreferrer">NotSupportedException</a></td>
<td>The underlying type of the <em>TEnum</em> type must be one of the following types: <a href="https://learn.microsoft.com/dotnet/api/system.sbyte" target="_blank" rel="noopener noreferrer">SByte</a>, <a href="https://learn.microsoft.com/dotnet/api/system.int16" target="_blank" rel="noopener noreferrer">Int16</a>, <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a>, <a href="https://learn.microsoft.com/dotnet/api/system.int64" target="_blank" rel="noopener noreferrer">Int64</a>, <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>, <a href="https://learn.microsoft.com/dotnet/api/system.uint16" target="_blank" rel="noopener noreferrer">UInt16</a>, <a href="https://learn.microsoft.com/dotnet/api/system.uint32" target="_blank" rel="noopener noreferrer">UInt32</a>, <a href="https://learn.microsoft.com/dotnet/api/system.uint64" target="_blank" rel="noopener noreferrer">UInt64</a></td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a></td>
<td>If the <em>value</em> is invalid for the <em>TEnum</em> type.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.invalidoperationexception" target="_blank" rel="noopener noreferrer">InvalidOperationException</a></td>
<td>If the <em>value</em> represents more than one constants in the <em>TEnum</em> and a <a href="https://learn.microsoft.com/dotnet/api/system.flagsattribute" target="_blank" rel="noopener noreferrer">FlagsAttribute</a> is not applied to that type.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum) Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  