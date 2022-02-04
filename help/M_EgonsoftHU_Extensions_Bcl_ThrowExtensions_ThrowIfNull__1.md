# ThrowExtensions.ThrowIfNull(*T*) Method (Nullable(*T*), String)
 

Throws <a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a> if *param* is `null`.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 1.0.0+9325be82c553e7a30a21061ab8fcab78fd7db9a2

## Syntax

**C#**<br />
``` C#
public static void ThrowIfNull<T>(
	this T? param,
	string paramName
)
where T : struct, new()

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub ThrowIfNull(Of T As {Structure, New}) ( 
	param As T?,
	paramName As String
)
```


#### Parameters
&nbsp;<dl><dt>param</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.nullable-1" target="_blank" rel="noopener noreferrer">System.Nullable</a>(*T*)<br />The parameter to check.</dd><dt>paramName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The name of the parameter.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of the *param*</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.nullable-1" target="_blank" rel="noopener noreferrer">Nullable</a>(*T*). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td /></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ThrowExtensions.md">ThrowExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_ThrowExtensions_ThrowIfNull.md">ThrowIfNull Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />