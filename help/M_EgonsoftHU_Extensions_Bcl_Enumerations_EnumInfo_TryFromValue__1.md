# TryFromValue&lt;TEnum&gt; Method


Gets an instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents one or more constants in the *TEnum* type the value of which equals to the specified *value*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static bool TryFromValue<TEnum>(
	TEnum value,
	out EnumInfo<TEnum>? result
)
where TEnum : struct, new()

```
**VB**
``` VB
Public Shared Function TryFromValue(Of TEnum As {Structure, New}) ( 
	value As TEnum,
	<OutAttribute> ByRef result As EnumInfo(Of TEnum)
) As Boolean
```



#### Parameters
<dl><dt>  TEnum</dt><dd>An enumeration value.</dd><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(TEnum)</dt><dd>An instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents the constant(s) in the <em>TEnum</em> type.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the enumeration.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if *value* was valid; otherwise, false.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo.md">EnumInfo Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  
