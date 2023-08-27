# ThrowExtensions.ThrowIfNotEqualTo(*T*) Method 
 

Throws an <a href="https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_blank" rel="noopener noreferrer">ArgumentOutOfRangeException</a> if *value* is not equal to *other*.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static void ThrowIfNotEqualTo<T>(
	this T value,
	T other,
	string? paramName = null
)
where T : Object, IEquatable<T>

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub ThrowIfNotEqualTo(Of T As {Object, IEquatable(Of T)}) ( 
	value As T,
	other As T,
	Optional paramName As String = Nothing
)
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: *T*<br />The argument to validate as equal to *other*.</dd><dt>other</dt><dd>Type: *T*<br />The value to compare with *value*.</dd><dt>paramName (Optional)</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The name of the parameter with which *value* corresponds.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>A type that implements  interface.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ThrowExtensions.md">ThrowExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br /><a href="https://learn.microsoft.com/dotnet/api/system.iequatable-1" target="_blank" rel="noopener noreferrer">System.IEquatable(T)</a><br />