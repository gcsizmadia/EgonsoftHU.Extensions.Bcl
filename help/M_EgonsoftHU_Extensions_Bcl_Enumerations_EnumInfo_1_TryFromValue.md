# TryFromValue Method


Gets an instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents one or more constants in the *TEnum* type the value of which equals to the specified *value*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static bool TryFromValue(
	TEnum value,
	out EnumInfo<TEnum>? result
)
```
**VB**
``` VB
Public Shared Function TryFromValue ( 
	value As TEnum,
	<OutAttribute> ByRef result As EnumInfo(Of TEnum)
) As Boolean
```



#### Parameters
<dl><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a></dt><dd>An enumeration value.</dd><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a>)</dt><dd>An instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents the constant(s) in the <em>TEnum</em> type.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if *value* was valid; otherwise, false.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum) Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  