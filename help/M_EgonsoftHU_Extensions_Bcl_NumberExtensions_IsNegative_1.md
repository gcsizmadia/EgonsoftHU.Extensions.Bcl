# IsNegative(Decimal) Method


Determines if a value represents a negative real number.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static bool IsNegative(
	this decimal value
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function IsNegative ( 
	value As Decimal
) As Boolean
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.decimal" target="_blank" rel="noopener noreferrer">Decimal</a></dt><dd>The value to be checked.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if *value* represents negative zero or a negative real number; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.decimal" target="_blank" rel="noopener noreferrer">Decimal</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Remarks

If this type has signed zero, then `-0` is also considered negative.

This function returning false does not imply that <a href="M_EgonsoftHU_Extensions_Bcl_NumberExtensions_IsPositive_1.md">IsPositive(Decimal)</a> will return true.

Please note:  
C# compiler does not treat `-0m` as negative zero, although it does get both the sign and the scale correctly for `-0.0m`.


## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_NumberExtensions.md">NumberExtensions Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_NumberExtensions_IsNegative.md">IsNegative Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  