# GetAttribute&lt;TAttribute&gt; Method


Gets a custom attribute of a specified *TAttribute* type that is applied to the current enum member.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
TAttribute GetAttribute<TAttribute>()
where TAttribute : Attribute

```
**VB**
``` VB
Function GetAttribute(Of TAttribute As Attribute) As TAttribute
```



#### Type Parameters
<dl><dt /><dd>The type of the attribute.</dd></dl>

#### Return Value
TAttribute  
A custom attribute of the specified *TAttribute* type, if applied to the current enum member; otherwise, null.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_IEnumerationAttributes.md">IEnumerationAttributes Interface</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  
