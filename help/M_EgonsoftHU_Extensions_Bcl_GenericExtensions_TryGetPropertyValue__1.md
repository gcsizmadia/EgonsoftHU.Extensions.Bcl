# GenericExtensions.TryGetPropertyValue(*TSource*) Method 
 

Gets the value of an instance property of the source object using reflection.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+8ead0a244466e154a5be3ab837e77f44c8ca5aac

## Syntax

**C#**<br />
``` C#
public static bool TryGetPropertyValue<TSource>(
	this TSource sourceObject,
	string propertyName,
	out Object?? value
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function TryGetPropertyValue(Of TSource) ( 
	sourceObject As TSource,
	propertyName As String,
	<OutAttribute> ByRef value As Object
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>sourceObject</dt><dd>Type: *TSource*<br />The source object whose property value should be get.</dd><dt>propertyName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The name of the property whose value should be get.</dd><dt>value</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">System.Object</a><br />The value of a property of the source object.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TSource</dt><dd>The type of the source object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />Returns true if the property exists; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>*propertyName* is a null reference (`Nothing` in Visual Basic), <a href="https://docs.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a> or consists only of white-space characters.</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />