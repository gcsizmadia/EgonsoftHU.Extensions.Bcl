# GenericExtensions.IsIn(*T*) Method (*T*, *T*[])
 

Determines whether a specified collection contains the current value by using the default equality comparer.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+8ead0a244466e154a5be3ab837e77f44c8ca5aac

## Syntax

**C#**<br />
``` C#
public static bool IsIn<T>(
	this T value,
	params T[] acceptedValues
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsIn(Of T) ( 
	value As T,
	ParamArray acceptedValues As T()
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: *T*<br />The value to locate in the collection.</dd><dt>acceptedValues</dt><dd>Type: *T*[]<br />A collection in which to locate a value.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of both the current value and the elements in *acceptedValues*.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />Returns true if the specified collection contains an element that has the specified value; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsIn.md">IsIn Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />