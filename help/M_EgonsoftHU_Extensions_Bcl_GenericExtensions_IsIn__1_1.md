# IsIn&lt;T&gt;(T, T[]) Method


Determines whether a specified collection contains the current value by using the default equality comparer.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static bool IsIn<T>(
	this T value,
	params T[] values
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function IsIn(Of T) ( 
	value As T,
	ParamArray values As T()
) As Boolean
```



#### Parameters
<dl><dt>  T</dt><dd>The value to locate in the collection.</dd><dt>  T[]</dt><dd>A collection in which to locate a value.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of both the current value and the elements in <em>values</em>.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
Returns true if the specified collection contains an element that has the specified value; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type T. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsIn.md">IsIn Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
