# ToMinutePrecision Method


Removes the seconds and the fractional seconds from the *value*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static DateTimeOffset ToMinutePrecision(
	this DateTimeOffset value
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function ToMinutePrecision ( 
	value As DateTimeOffset
) As DateTimeOffset
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a></dt><dd>The <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a> value from which to remove the seconds and the fractional seconds.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a>  
A <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a> value with zero seconds.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_DateTimeOffsetExtensions.md">DateTimeOffsetExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
