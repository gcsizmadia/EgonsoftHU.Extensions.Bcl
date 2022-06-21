# GenericExtensions.IsNotIn(*T*) Method (*T*, IEqualityComparer(*T*), *T*[])
 

Determines whether a specified collection does not contain the current value by using the default equality comparer.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+92afa6294581b57a0a05c47f5fa89680af93d830

## Syntax

**C#**<br />
``` C#
public static bool IsNotIn<T>(
	this T value,
	IEqualityComparer<T>? equalityComparer,
	params T[] deniedValues
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsNotIn(Of T) ( 
	value As T,
	equalityComparer As IEqualityComparer(Of T),
	ParamArray deniedValues As T()
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: *T*<br />The value to locate in the collection.</dd><dt>equalityComparer</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1" target="_blank" rel="noopener noreferrer">System.Collections.Generic.IEqualityComparer</a>(*T*)<br />An equality comparer to compare values.</dd><dt>deniedValues</dt><dd>Type: *T*[]<br />A collection in which to locate a value.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of both the current value and the elements in *deniedValues*.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />Returns true if the specified collection does not contain an element that has the specified value; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsNotIn.md">IsNotIn Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />