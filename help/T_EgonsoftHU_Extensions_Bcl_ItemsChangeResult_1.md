# ItemsChangeResult&lt;TItem&gt; Class


Represents the difference between two sets of items as groups of new, existing and removed items.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public class ItemsChangeResult<TItem> : IEquatable<ItemsChangeResult<TItem>>

```
**VB**
``` VB
Public Class ItemsChangeResult(Of TItem)
	Implements IEquatable(Of ItemsChangeResult(Of TItem))
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  ItemsChangeResult(TItem)</td></tr>
<tr><td><strong>Implements</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.iequatable-1" target="_blank" rel="noopener noreferrer">IEquatable</a>(ItemsChangeResult(TItem))</td></tr>
</table>



#### Type Parameters
<dl><dt /><dd>The type of the items.</dd></dl>

## Constructors
<table>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1__ctor.md">ItemsChangeResult(TItem)</a></td>
<td>Represents the difference between two sets of items as groups of new, existing and removed items.</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1_ItemsToAdd.md">ItemsToAdd</a></td>
<td>Incoming items to add.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1_ItemsToRemove.md">ItemsToRemove</a></td>
<td>Existing items to be removed.</td></tr>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_ItemsChangeResult_1_ItemsToUpdate.md">ItemsToUpdate</a></td>
<td>Incoming items based on which to update existing items.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
