# Serialize&lt;TEnum&gt; Method


Converts the member of an enum type specified by the *TEnum* type parameter into a string.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization.md">EgonsoftHU.Extensions.Bcl.Enumerations.Serialization</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public abstract string Serialize<TEnum>(
	EnumInfo<TEnum> enumeration
)
where TEnum : struct, new()

```
**VB**
``` VB
Public MustOverride Function Serialize(Of TEnum As {Structure, New}) ( 
	enumeration As EnumInfo(Of TEnum)
) As String
```



#### Parameters
<dl><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(TEnum)</dt><dd>An instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents a member of the <em>TEnum</em> type.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the enumeration.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
A string representation of the enum member represented by the *enumeration* parameter.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization_EnumValueSerializer.md">EnumValueSerializer Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization.md">EgonsoftHU.Extensions.Bcl.Enumerations.Serialization Namespace</a>  
