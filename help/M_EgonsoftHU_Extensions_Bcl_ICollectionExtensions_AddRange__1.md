# ICollectionExtensions.AddRange(*T*) Method 
 

Adds the elements of the specified collection to the end of the current *collection*.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static void AddRange<T>(
	this ICollection<T> collection,
	IEnumerable<T> items
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub AddRange(Of T) ( 
	collection As ICollection(Of T),
	items As IEnumerable(Of T)
)
```


#### Parameters
&nbsp;<dl><dt>collection</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1" target="_blank" rel="noopener noreferrer">System.Collections.Generic.ICollection</a>(*T*)<br />The current collection to the end of which the elements of the specified collection will be added.</dd><dt>items</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">System.Collections.Generic.IEnumerable</a>(*T*)<br />The collection whose elements should be added to the end of the current *collection*. The collection itself cannot be a null reference (`Nothing` in Visual Basic), but it can contain elements that are a null reference (`Nothing` in Visual Basic), if type *T* is a nullable reference/value type.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of the elements of source.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1" target="_blank" rel="noopener noreferrer">ICollection</a>(*T*). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>Either *collection* or *items* is a null reference (`Nothing` in Visual Basic).</td></tr><tr><td><a href="https://learn.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a></td><td>*collection* is read-only.</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ICollectionExtensions.md">ICollectionExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />