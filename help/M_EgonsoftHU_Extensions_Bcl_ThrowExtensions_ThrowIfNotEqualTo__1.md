# ThrowIfNotEqualTo&lt;T&gt; Method


Throws an <a href="https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_blank" rel="noopener noreferrer">ArgumentOutOfRangeException</a> if *value* is not equal to *other*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static void ThrowIfNotEqualTo<T>(
	this T value,
	T other,
	string? paramName = null
)
where T : Object, IEquatable<T>

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Sub ThrowIfNotEqualTo(Of T As {Object, IEquatable(Of T)}) ( 
	value As T,
	other As T,
	Optional paramName As String = Nothing
)
```



#### Parameters
<dl><dt>  T</dt><dd>The argument to validate as equal to <em>other</em>.</dd><dt>  T</dt><dd>The value to compare with <em>value</em>.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  (Optional)</dt><dd>The name of the parameter with which <em>value</em> corresponds.</dd></dl>

#### Type Parameters
<dl><dt /><dd>A type that implements  interface.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type T. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ThrowExtensions.md">ThrowExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
<a href="https://learn.microsoft.com/dotnet/api/system.iequatable-1" target="_blank" rel="noopener noreferrer">IEquatable(T)</a>  
