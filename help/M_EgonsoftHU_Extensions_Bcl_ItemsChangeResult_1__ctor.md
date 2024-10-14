# ItemsChangeResult&lt;TItem&gt; Constructor


Represents the difference between two sets of items as groups of new, existing and removed items.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public ItemsChangeResult(
	IReadOnlyList<TItem> ItemsToAdd,
	IReadOnlyList<TItem> ItemsToUpdate,
	IReadOnlyList<TItem> ItemsToRemove
)
```
**VB**
``` VB
Public Sub New ( 
	ItemsToAdd As IReadOnlyList(Of TItem),
	ItemsToUpdate As IReadOnlyList(Of TItem),
	ItemsToRemove As IReadOnlyList(Of TItem)
)
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" rel="noopener noreferrer">IReadOnlyList</a>(<a href="T_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1.md">TItem</a>)</dt><dd>Incoming items to add.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" rel="noopener noreferrer">IReadOnlyList</a>(<a href="T_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1.md">TItem</a>)</dt><dd>Incoming items based on which to update existing items.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" rel="noopener noreferrer">IReadOnlyList</a>(<a href="T_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1.md">TItem</a>)</dt><dd>Existing items to be removed.</dd></dl>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1.md">ItemsChangeResult(TItem) Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
