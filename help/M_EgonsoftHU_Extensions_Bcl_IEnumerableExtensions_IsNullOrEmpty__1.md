# IEnumerableExtensions.IsNullOrEmpty(*T*) Method 
 

Determines whether a sequence is a null reference (`Nothing` in Visual Basic) or contains no element.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+92afa6294581b57a0a05c47f5fa89680af93d830

## Syntax

**C#**<br />
``` C#
public static bool IsNullOrEmpty<T>(
	this IEnumerable<T>? sequence
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsNullOrEmpty(Of T) ( 
	sequence As IEnumerable(Of T)
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>sequence</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">System.Collections.Generic.IEnumerable</a>(*T*)<br />The sequence to check if it is a null reference (`Nothing` in Visual Basic) or contains no element.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of the elements of source.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />`true` (`True` in Visual Basic) if the *sequence* is a null reference (`Nothing` in Visual Basic) or contains no element; otherwise, `false` (`False` in Visual Basic).

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(*T*). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IEnumerableExtensions.md">IEnumerableExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />