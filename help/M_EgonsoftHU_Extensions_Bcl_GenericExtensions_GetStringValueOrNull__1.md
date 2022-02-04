# GenericExtensions.GetStringValueOrNull(*TSource*) Method 
 

Gets a string value using a specified value selector or null. The value selector gets the source object as input parameter.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 1.0.0+57d106ced6f68f75c199e9a058b20d290f7a3f96@@+105

## Syntax

**C#**<br />
``` C#
public static string GetStringValueOrNull<TSource>(
	this TSource sourceObject,
	Func<TSource, string> valueSelector
)
where TSource : class

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetStringValueOrNull(Of TSource As Class) ( 
	sourceObject As TSource,
	valueSelector As Func(Of TSource, String)
) As String
```


#### Parameters
&nbsp;<dl><dt>sourceObject</dt><dd>Type: *TSource*<br />The source object that can be used by a value selector.</dd><dt>valueSelector</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">System.Func</a>(*TSource*, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>)<br />A value selector that gets the source object as input parameter and returns a value.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TSource</dt><dd>The type of the source object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a><br />Returns a string value returned by the specified value selector if source object is not null and the returned value is not null; otherwise, null.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>Thrown when the value selector is null.</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />