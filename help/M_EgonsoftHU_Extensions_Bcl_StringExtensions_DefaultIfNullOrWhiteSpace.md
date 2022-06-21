# StringExtensions.DefaultIfNullOrWhiteSpace Method 
 

Gets the specified default value if the specified string is a null reference (`Nothing` in Visual Basic), <a href="https://docs.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>, or consists only of white-space characters.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+8ead0a244466e154a5be3ab837e77f44c8ca5aac

## Syntax

**C#**<br />
``` C#
public static string? DefaultIfNullOrWhiteSpace(
	this string? value,
	string? defaultValue = null
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function DefaultIfNullOrWhiteSpace ( 
	value As String,
	Optional defaultValue As String = Nothing
) As String
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The string to test.</dd><dt>defaultValue (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The default value if *value* is a null reference (`Nothing` in Visual Basic), <a href="https://docs.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>, or consists only of white-space characters.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a><br />*defaultValue* if *value* is a null reference (`Nothing` in Visual Basic), <a href="https://docs.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>, or if *value* consists exclusively of white-space characters; otherwise, *value* itself.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_StringExtensions.md">StringExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />