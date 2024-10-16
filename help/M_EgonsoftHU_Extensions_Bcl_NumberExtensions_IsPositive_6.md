# IsPositive(SByte) Method


Determines if a value represents (positive) zero or a positive real number.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static bool IsPositive(
	this sbyte value
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function IsPositive ( 
	value As SByte
) As Boolean
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.sbyte" target="_blank" rel="noopener noreferrer">SByte</a></dt><dd>The value to be checked.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if *value* represents (positive) zero or a positive real number; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.sbyte" target="_blank" rel="noopener noreferrer">SByte</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Remarks

If this type has signed zero, then `-0` is not considered positive, but `+0` is.

This function returning false does not imply that <a href="M_EgonsoftHU_Extensions_Bcl_NumberExtensions_IsNegative_6.md">IsNegative(SByte)</a> will return true.


## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_NumberExtensions.md">NumberExtensions Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_NumberExtensions_IsPositive.md">IsPositive Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
