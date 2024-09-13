# StructuralEqualityComparer&lt;T&gt; Class


Provides an <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1" target="_blank" rel="noopener noreferrer">IEqualityComparer(T)</a> implementation for structural equality comparison.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Collections_Generic.md">EgonsoftHU.Extensions.Bcl.Collections.Generic</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public sealed class StructuralEqualityComparer<T> : IEqualityComparer<T>

```
**VB**
``` VB
Public NotInheritable Class StructuralEqualityComparer(Of T)
	Implements IEqualityComparer(Of T)
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  StructuralEqualityComparer(T)</td></tr>
<tr><td><strong>Implements</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1" target="_blank" rel="noopener noreferrer">IEqualityComparer</a>(T)</td></tr>
</table>



#### Type Parameters
<dl><dt /><dd>The type of objects to compare.</dd></dl>

## Remarks
With this comparer you can use types that implement <a href="https://learn.microsoft.com/dotnet/api/system.collections.istructuralequatable" target="_blank" rel="noopener noreferrer">IStructuralEquatable</a> interface (e.g. arrays, value tuples) as the key in a dictionary.

## Example


**Using the constructor.**  
``` C#
var dictionary = new Dictionary<byte[], object>(StructuralEqualityComparer<byte[]>.Default);
```


**Using LINQ.**  
``` C#
var dictionary =
    collection.ToDictionary(
        element => element.ByteArrayProperty,
        element => element,
        StructuralEqualityComparer<byte[]>.Default
    );
```


## Constructors
<table>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Collections_Generic_StructuralEqualityComparer_1__ctor.md">StructuralEqualityComparer(T)</a></td>
<td>Initializes a new instance of the StructuralEqualityComparer(T) class</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="P_EgonsoftHU_Extensions_Bcl_Collections_Generic_StructuralEqualityComparer_1_Default.md">Default</a></td>
<td>Returns a default structural equality comparer for the type specified by the generic argument.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals(Object)</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Collections_Generic_StructuralEqualityComparer_1_Equals.md">Equals(T, T)</a></td>
<td>Determines whether the specified objects are equal.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode()</a></td>
<td>Serves as the default hash function.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_EgonsoftHU_Extensions_Bcl_Collections_Generic_StructuralEqualityComparer_1_GetHashCode.md">GetHashCode(T)</a></td>
<td>Returns a hash code for the specified object.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_EgonsoftHU_Extensions_Bcl_Collections_Generic.md">EgonsoftHU.Extensions.Bcl.Collections.Generic Namespace</a>  
