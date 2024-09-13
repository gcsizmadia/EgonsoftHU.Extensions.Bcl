# GetValue&lt;TSource, TResult&gt; Method


Gets a value using a specified value selector that gets the source object as input parameter.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static TResult GetValue<TSource, TResult>(
	this TSource sourceObject,
	Func<TSource, TResult> valueSelector
)
where TSource : class

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function GetValue(Of TSource As Class, TResult) ( 
	sourceObject As TSource,
	valueSelector As Func(Of TSource, TResult)
) As TResult
```



#### Parameters
<dl><dt>  TSource</dt><dd>The source object that can be used by a value selector.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(TSource, TResult)</dt><dd>A value selector that gets the source object as input parameter and returns a value.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the source object.</dd><dt /><dd>The type of the value that is returned by the value selector.</dd></dl>

#### Return Value
TResult  
A value returned by the *valueSelector*.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type TSource. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td>Either <em>sourceObject</em> or <em>valueSelector</em> is null.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_GenericExtensions.md">GenericExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
