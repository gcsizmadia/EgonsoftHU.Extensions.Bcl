# Current Property


Gets or sets the current serializer for enum values.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization.md">EgonsoftHU.Extensions.Bcl.Enumerations.Serialization</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static EnumValueSerializer Current { get; set; }
```
**VB**
``` VB
Public Shared Property Current As EnumValueSerializer
	Get
	Set
```



#### Property Value
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization_EnumValueSerializer.md">EnumValueSerializer</a>

## Remarks
If a custom implementation of this type is used for JSON serialization then set this property to that implementation where the JSON serializer options are configured. 
When accessing a specific <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type then the current value of this property will be used to initialize the <a href="P_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_SerializedValue.md">SerializedValue</a> property for all the declared members of that enum type; therefore, it is highly recommended to set this property only once and only at application startup.


## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization_EnumValueSerializer.md">EnumValueSerializer Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations_Serialization.md">EgonsoftHU.Extensions.Bcl.Enumerations.Serialization Namespace</a>  
