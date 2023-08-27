# IDictionaryExtensions.GetOrThrow(*TKey*, *TValue*) Method 
 

Gets the value associated with the specified key.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static TValue GetOrThrow<TKey, TValue>(
	this IDictionary<TKey, TValue> dictionary,
	TKey key
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetOrThrow(Of TKey, TValue) ( 
	dictionary As IDictionary(Of TKey, TValue),
	key As TKey
) As TValue
```


#### Parameters
&nbsp;<dl><dt>dictionary</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">System.Collections.Generic.IDictionary</a>(*TKey*, *TValue*)<br />The dictionary from which the value for the specified key is retrieved.</dd><dt>key</dt><dd>Type: *TKey*<br />The key whose value to get.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TKey</dt><dd>The type of keys in the dictionary.</dd><dt>TValue</dt><dd>The type of values in the dictionary.</dd></dl>

#### Return Value
Type: *TValue*<br />The value associated with the specified key, if the key is found; otherwise, <a href="https://learn.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a> is thrown.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary</a>(*TKey*, *TValue*). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>Either *dictionary* or *key* is a null reference (`Nothing` in Visual Basic).</td></tr><tr><td><a href="https://learn.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a></td><td>The given *key* was not present in the *dictionary*.</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IDictionaryExtensions.md">IDictionaryExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />