# Deserialize&lt;TEnum&gt; Method


Retrieves an <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> instance by the specified *serializedValue*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization.md">EgonsoftHU.Extensions.Bcl.Enumerations.Serialization</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public abstract EnumInfo<TEnum>? Deserialize<TEnum>(
	string serializedValue
)
where TEnum : struct, new()

```
**VB**
``` VB
Public MustOverride Function Deserialize(Of TEnum As {Structure, New}) ( 
	serializedValue As String
) As EnumInfo(Of TEnum)
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The string representation of an enumeration value.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the enumeration.</dd></dl>

#### Return Value
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(TEnum)  
An <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> instance if *serializedValue* is recognized as a valid enumeration value; otherwise, null.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization_EnumValueSerializer.md">EnumValueSerializer Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization.md">EgonsoftHU.Extensions.Bcl.Enumerations.Serialization Namespace</a>  
