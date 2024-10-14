# SetPropertyValue&lt;TSource&gt; Method


Sets the value of an instance property of the source object using reflection.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static void SetPropertyValue<TSource>(
	this TSource sourceObject,
	string propertyName,
	Object? value
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Sub SetPropertyValue(Of TSource) ( 
	sourceObject As TSource,
	propertyName As String,
	value As Object
)
```



#### Parameters
<dl><dt>  TSource</dt><dd>The source object whose property value should be set.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The name of the property whose value should be set.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a></dt><dd>The value to be set as the value of the property of the source object.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the source object.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type TSource. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td><em>propertyName</em> is null, <a href="https://learn.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a> or consists only of white-space characters.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a></td>
<td>No property is declared in <em>TSource</em> type with the specified <em>propertyName</em>.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
