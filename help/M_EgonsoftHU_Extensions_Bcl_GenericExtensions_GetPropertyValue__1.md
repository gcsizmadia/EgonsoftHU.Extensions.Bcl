# GenericExtensions.GetPropertyValue(*TSource*) Method 
 

Gets the value of an instance property of the source object using reflection.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 1.0.3+6715e4ae393d52b571db441794d1069c783f8c2f

## Syntax

**C#**<br />
``` C#
public static Object GetPropertyValue<TSource>(
	this TSource sourceObject,
	string propertyName
)
where TSource : class

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetPropertyValue(Of TSource As Class) ( 
	sourceObject As TSource,
	propertyName As String
) As Object
```


#### Parameters
&nbsp;<dl><dt>sourceObject</dt><dd>Type: *TSource*<br />The source object whose property value should be get.</dd><dt>propertyName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The name of the property whose value should be get.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TSource</dt><dd>The type of the source object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a><br />A property value of the source object if the property exists; otherwise, null.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />