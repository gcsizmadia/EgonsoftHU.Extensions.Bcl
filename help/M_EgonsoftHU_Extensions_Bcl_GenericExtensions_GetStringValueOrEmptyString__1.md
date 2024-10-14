# GetStringValueOrEmptyString&lt;TSource&gt; Method


Gets a string value using a specified value selector or <a href="https://learn.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>. The value selector gets the source object as input parameter.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static string GetStringValueOrEmptyString<TSource>(
	this TSource sourceObject,
	Func<TSource, string?> valueSelector
)
where TSource : class

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function GetStringValueOrEmptyString(Of TSource As Class) ( 
	sourceObject As TSource,
	valueSelector As Func(Of TSource, String)
) As String
```



#### Parameters
<dl><dt>  TSource</dt><dd>The source object that can be used by a value selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(TSource, <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>)</dt><dd>A value selector that gets the source object as input parameter and returns a value.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the source object.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
A string value returned by the *valueSelector* if it is not equal to null; otherwise, the <a href="https://learn.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type TSource. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td>Either <em>sourceObject</em> or <em>valueSelector</em> is null.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
