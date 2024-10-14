# GetTypeName(Type) Method


Gets the fully qualified name of the *type*, including its namespace but not its assembly, if available; otherwise, the name of the *type*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static string GetTypeName(
	Type? type
)
```
**VB**
``` VB
Public Shared Function GetTypeName ( 
	type As Type
) As String
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a></dt><dd>The <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> the name of which to get.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
The fully qualified name of the *type*, including its namespace but not its assembly, if available; otherwise, the name of the *type*.

## Remarks
If *type* is null then an empty string is returned.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_TypeHelper.md">TypeHelper Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_TypeHelper_GetTypeName.md">GetTypeName Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
