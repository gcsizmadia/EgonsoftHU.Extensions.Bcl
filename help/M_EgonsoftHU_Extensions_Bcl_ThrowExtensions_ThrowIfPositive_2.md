# ThrowExtensions.ThrowIfPositive Method (Double, String)
 

Throws an <a href="https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_blank" rel="noopener noreferrer">ArgumentOutOfRangeException</a> if *value* is positive.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static void ThrowIfPositive(
	this double value,
	string? paramName = null
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub ThrowIfPositive ( 
	value As Double,
	Optional paramName As String = Nothing
)
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.double" target="_blank" rel="noopener noreferrer">System.Double</a><br />The argument to validate as non-positive.</dd><dt>paramName (Optional)</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The name of the parameter with which *value* corresponds.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.double" target="_blank" rel="noopener noreferrer">Double</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ThrowExtensions.md">ThrowExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_ThrowExtensions_ThrowIfPositive.md">ThrowIfPositive Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />