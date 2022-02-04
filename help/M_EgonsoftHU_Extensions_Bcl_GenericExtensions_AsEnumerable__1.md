# GenericExtensions.AsEnumerable(*T*) Method 
 

Returns a value as a sequence that contains only that value.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 1.0.0+57d106ced6f68f75c199e9a058b20d290f7a3f96@@+105

## Syntax

**C#**<br />
``` C#
public static IEnumerable<T> AsEnumerable<T>(
	this T value
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AsEnumerable(Of T) ( 
	value As T
) As IEnumerable(Of T)
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: *T*<br />A value to be returned as <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable(T)</a>.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of the value.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(*T*)<br />Returns a sequence that contains only specified value.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />