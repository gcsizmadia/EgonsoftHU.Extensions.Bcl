# GenericExtensions.GetValueOrDefault(*TSource*, *TResult*) Method 
 

Gets a value using a specified value selector or a specified default value. The value selector gets the source object as input parameter.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+92afa6294581b57a0a05c47f5fa89680af93d830

## Syntax

**C#**<br />
``` C#
public static TResult GetValueOrDefault<TSource, TResult>(
	this TSource sourceObject,
	Func<TSource, TResult> valueSelector,
	TResult defaultValue
)
where TSource : class

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetValueOrDefault(Of TSource As Class, TResult) ( 
	sourceObject As TSource,
	valueSelector As Func(Of TSource, TResult),
	defaultValue As TResult
) As TResult
```


#### Parameters
&nbsp;<dl><dt>sourceObject</dt><dd>Type: *TSource*<br />The source object that can be used by a value selector.</dd><dt>valueSelector</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">System.Func</a>(*TSource*, *TResult*)<br />A value selector that gets the source object as input parameter and returns a value.</dd><dt>defaultValue</dt><dd>Type: *TResult*<br />The value to be returned if the value returned by the value selector is the default value of the return type.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TSource</dt><dd>The type of the source object.</dd><dt>TResult</dt><dd>The type of the value that is returned by the value selector.</dd></dl>

#### Return Value
Type: *TResult*<br />A value returned by the *valueSelector* if it is not equal to `default(*TResult*)`; otherwise, the *defaultValue*.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>Either *sourceObject* or *valueSelector* is a null reference (`Nothing` in Visual Basic).</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />