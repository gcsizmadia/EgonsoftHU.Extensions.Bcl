# ThrowExtensions.ThrowIfNullOrEmpty Method 
 

Throws <a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a> if *param* is `null` or <a href="https://docs.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 1.0.2+e8b59cc7854e9943402e9b0b9a39741fce47cfc0

## Syntax

**C#**<br />
``` C#
public static void ThrowIfNullOrEmpty(
	this string param,
	string paramName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub ThrowIfNullOrEmpty ( 
	param As String,
	paramName As String
)
```


#### Parameters
&nbsp;<dl><dt>param</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The parameter to check.</dd><dt>paramName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The name of the parameter.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td /></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ThrowExtensions.md">ThrowExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />