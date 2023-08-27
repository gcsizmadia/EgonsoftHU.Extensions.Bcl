# DateTimeOffsetExtensions.ToSecondPrecision Method 
 

Removes the fractional seconds from the *value*.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static DateTimeOffset ToSecondPrecision(
	this DateTimeOffset value
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ToSecondPrecision ( 
	value As DateTimeOffset
) As DateTimeOffset
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">System.DateTimeOffset</a><br />The <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a> value from which to remove the fractional seconds.</dd></dl>

#### Return Value
Type: <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a><br />A <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a> value with no fractional seconds.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.datetimeoffset" target="_blank" rel="noopener noreferrer">DateTimeOffset</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_DateTimeOffsetExtensions.md">DateTimeOffsetExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />