# DetectChanges&lt;TItem, TKey&gt;(IEnumerable&lt;TItem&gt;, IEnumerable&lt;TItem&gt;, Func&lt;TItem, TKey&gt;) Method


Groups the difference between *incomingItems* and *existingItems* into new, existing and removed items according to a specified key selector function.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static ItemsChangeResult<TItem> DetectChanges<TItem, TKey>(
	this IEnumerable<TItem>? existingItems,
	IEnumerable<TItem>? incomingItems,
	Func<TItem, TKey> keySelector
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function DetectChanges(Of TItem, TKey) ( 
	existingItems As IEnumerable(Of TItem),
	incomingItems As IEnumerable(Of TItem),
	keySelector As Func(Of TItem, TKey)
) As ItemsChangeResult(Of TItem)
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(TItem)</dt><dd>An <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable(T)</a> whose keys that are not also in <em>incomingItems</em> will be returned as removed items.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(TItem)</dt><dd>An <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable(T)</a> the elements of which will be returned either as new or existing items.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(TItem, TKey)</dt><dd>A function to extract the key for each element.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the items.</dd><dt /><dd>The type of the key of an item.</dd></dl>

#### Return Value
<a href="T_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1.md">ItemsChangeResult</a>(TItem)  
An instance of the <a href="T_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1.md">ItemsChangeResult(TItem)</a> type representing the detected changes as new, existing and removed items.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" rel="noopener noreferrer">IEnumerable</a>(TItem). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IEnumerableExtensions.md">IEnumerableExtensions Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_IEnumerableExtensions_DetectChanges.md">DetectChanges Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
