# DefaultIfKeyNotFound&lt;TKey, TValue&gt; Method


Gets the value associated with the specified key or a default value.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static TValue DefaultIfKeyNotFound<TKey, TValue>(
	this IDictionary<TKey, TValue> dictionary,
	TKey key,
	TValue defaultValue
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function DefaultIfKeyNotFound(Of TKey, TValue) ( 
	dictionary As IDictionary(Of TKey, TValue),
	key As TKey,
	defaultValue As TValue
) As TValue
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary</a>(TKey, TValue)</dt><dd>The dictionary from which the value for the specified key is retrieved.</dd><dt>  TKey</dt><dd>The key whose value to get.</dd><dt>  TValue</dt><dd>The value to return if <em>key</em> is not found.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of keys in the dictionary.</dd><dt /><dd>The type of values in the dictionary.</dd></dl>

#### Return Value
TValue  
The value associated with the specified key, if the key is found; otherwise, *defaultValue*.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary</a>(TKey, TValue). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IDictionaryExtensions.md">IDictionaryExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
