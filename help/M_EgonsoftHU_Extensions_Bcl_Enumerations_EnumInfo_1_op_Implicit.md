# Implicit Conversion (EnumInfo&lt;TEnum&gt; to TEnum)


Defines an implicit conversion of an instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type to its underlying enum value.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static implicit operator TEnum (
	EnumInfo<TEnum>? value
)
```
**VB**
``` VB
Public Shared Widening Operator CType ( 
	value As EnumInfo(Of TEnum)
) As TEnum
```



#### Parameters
<dl><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a>)</dt><dd>An enum member represented by an instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type.</dd></dl>

#### Return Value
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a>  
The value of the <a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_Value.md">Value</a> property for the *value* parameter if it is not null; otherwise, the default value of the *TEnum* enum type.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum) Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_Implicit.md">Implicit Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  
