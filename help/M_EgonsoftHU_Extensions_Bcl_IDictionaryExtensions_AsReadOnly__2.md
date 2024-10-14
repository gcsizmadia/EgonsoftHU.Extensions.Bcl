# AsReadOnly&lt;TKey, TValue&gt; Method


Returns a read-only <a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.readonlydictionary-2" target="_blank" rel="noopener noreferrer">ReadOnlyDictionary(TKey, TValue)</a> wrapper for the current dictionary.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(
	this IDictionary<TKey, TValue> dictionary
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function AsReadOnly(Of TKey, TValue) ( 
	dictionary As IDictionary(Of TKey, TValue)
) As ReadOnlyDictionary(Of TKey, TValue)
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary</a>(TKey, TValue)</dt><dd>The dictionary to wrap into a read-only wrapper.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of keys in the dictionary.</dd><dt /><dd>The type of values in the dictionary.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.readonlydictionary-2" target="_blank" rel="noopener noreferrer">ReadOnlyDictionary</a>(TKey, TValue)  
An object that acts as a read-only wrapper around the current <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary(TKey, TValue)</a>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary</a>(TKey, TValue). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td><em>dictionary</em> is null.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IDictionaryExtensions.md">IDictionaryExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
