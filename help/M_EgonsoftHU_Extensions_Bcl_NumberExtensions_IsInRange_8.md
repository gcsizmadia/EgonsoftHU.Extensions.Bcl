# IsInRange(UInt16, UInt16, UInt16, IntervalBoundsOptions) Method


Indicates whether the specified <a href="https://learn.microsoft.com/dotnet/api/system.uint16" target="_blank" rel="noopener noreferrer">UInt16</a> value is in the specified interval.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static bool IsInRange(
	this ushort value,
	ushort lowerBound,
	ushort upperBound,
	IntervalBoundsOptions options = 0
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function IsInRange ( 
	value As UShort,
	lowerBound As UShort,
	upperBound As UShort,
	Optional options As IntervalBoundsOptions = 0
) As Boolean
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.uint16" target="_blank" rel="noopener noreferrer">UInt16</a></dt><dd>The value to compare against the lower bound and the upper bound.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.uint16" target="_blank" rel="noopener noreferrer">UInt16</a></dt><dd>The beginning of the interval.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.uint16" target="_blank" rel="noopener noreferrer">UInt16</a></dt><dd>The end of the interval.</dd><dt>  <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_IntervalBoundsOptions.md">IntervalBoundsOptions</a>  (Optional)</dt><dd>Specifies whether to treat the lower and upper bounds as inclusive or exclusive. By default, both are treated as inclusive.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true, if *value* is in the specified interval; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.uint16" target="_blank" rel="noopener noreferrer">UInt16</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_NumberExtensions.md">NumberExtensions Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_NumberExtensions_IsInRange.md">IsInRange Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
