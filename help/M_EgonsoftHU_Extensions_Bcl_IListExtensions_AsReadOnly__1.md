# AsReadOnly&lt;T&gt; Method


Returns a read-only <a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.readonlycollection-1" target="_blank" rel="noopener noreferrer">ReadOnlyCollection(T)</a> wrapper for the current collection.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static ReadOnlyCollection<T> AsReadOnly<T>(
	this IList<T> list
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function AsReadOnly(Of T) ( 
	list As IList(Of T)
) As ReadOnlyCollection(Of T)
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" target="_blank" rel="noopener noreferrer">IList</a>(T)</dt><dd>The list to wrap into a read-only wrapper.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of elements in the collection.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.readonlycollection-1" target="_blank" rel="noopener noreferrer">ReadOnlyCollection</a>(T)  
An object that acts as a read-only wrapper around the current <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" target="_blank" rel="noopener noreferrer">IList(T)</a>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" target="_blank" rel="noopener noreferrer">IList</a>(T). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td><em>list</em> is null.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IListExtensions.md">IListExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
