# Implicit Conversion (TEnum to EnumInfo&lt;TEnum&gt;)


Gets an instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type that represents the specified *value*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static implicit operator EnumInfo<TEnum> (
	TEnum value
)
```
**VB**
``` VB
Public Shared Widening Operator CType ( 
	value As TEnum
) As EnumInfo(Of TEnum)
```



#### Parameters
<dl><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a></dt><dd>An enum value.</dd></dl>

#### Return Value
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a>)  
The value returned by calling the <a href="M_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_FromValue.md">FromValue(TEnum)</a> method with the *value* parameter.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum) Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_op_Implicit.md">Implicit Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  
