# IDictionaryExtensions.AsReadOnly(*TKey*, *TValue*) Method 
 

Returns a read-only <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" rel="noopener noreferrer">IReadOnlyDictionary(TKey, TValue)</a> wrapper for the current dictionary.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static IReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(
	this IDictionary<TKey, TValue> dictionary
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AsReadOnly(Of TKey, TValue) ( 
	dictionary As IDictionary(Of TKey, TValue)
) As IReadOnlyDictionary(Of TKey, TValue)
```


#### Parameters
&nbsp;<dl><dt>dictionary</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">System.Collections.Generic.IDictionary</a>(*TKey*, *TValue*)<br />The dictionary to wrap into a read-only wrapper.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TKey</dt><dd>The type of keys in the dictionary.</dd><dt>TValue</dt><dd>The type of values in the dictionary.</dd></dl>

#### Return Value
Type: <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" rel="noopener noreferrer">IReadOnlyDictionary</a>(*TKey*, *TValue*)<br />An object that acts as a read-only wrapper around the current <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary(TKey, TValue)</a>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank" rel="noopener noreferrer">IDictionary</a>(*TKey*, *TValue*). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>*dictionary* is a null reference (`Nothing` in Visual Basic).</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_IDictionaryExtensions.md">IDictionaryExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />