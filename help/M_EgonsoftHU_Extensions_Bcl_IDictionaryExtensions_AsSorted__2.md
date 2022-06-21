# IDictionaryExtensions.AsSorted(*TKey*, *TValue*) Method 
 

Returns a collection of key/value pairs that are sorted on the key.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+8ead0a244466e154a5be3ab837e77f44c8ca5aac

## Syntax

**C#**<br />
``` C#
public static SortedDictionary<TKey, TValue> AsSorted<TKey, TValue>(
	this IDictionary<TKey, TValue> dictionary
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AsSorted(Of TKey, TValue) ( 
	dictionary As IDictionary(Of TKey, TValue)
) As SortedDictionary(Of TKey, TValue)
```


#### Parameters
&nbsp;<dl><dt>dictionary</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">System.Collections.Generic.IDictionary</a>(*TKey*, *TValue*)<br />The dictionary the key/value pairs of which are sorted on the key.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TKey</dt><dd>The type of keys in the dictionary.</dd><dt>TValue</dt><dd>The type of values in the dictionary.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.sorteddictionary-2" target="_blank" rel="noopener noreferrer">SortedDictionary</a>(*TKey*, *TValue*)<br />A collection of the original key/value pairs that are sorted on the key.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary</a>(*TKey*, *TValue*). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>*dictionary* is a null reference (`Nothing` in Visual Basic).</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IDictionaryExtensions.md">IDictionaryExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />