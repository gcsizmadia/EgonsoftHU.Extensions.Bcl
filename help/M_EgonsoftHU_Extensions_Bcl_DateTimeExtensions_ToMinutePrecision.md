# ToMinutePrecision Method


Removes the seconds and the fractional seconds from the *value*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static DateTime ToMinutePrecision(
	this DateTime value
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function ToMinutePrecision ( 
	value As DateTime
) As DateTime
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.datetime" target="_blank" rel="noopener noreferrer">DateTime</a></dt><dd>The <a href="https://learn.microsoft.com/dotnet/api/system.datetime" target="_blank" rel="noopener noreferrer">DateTime</a> value from which to remove the seconds and the fractional seconds.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.datetime" target="_blank" rel="noopener noreferrer">DateTime</a>  
A <a href="https://learn.microsoft.com/dotnet/api/system.datetime" target="_blank" rel="noopener noreferrer">DateTime</a> value with zero seconds.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.datetime" target="_blank" rel="noopener noreferrer">DateTime</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Remarks
The <a href="https://learn.microsoft.com/dotnet/api/system.datetimekind" target="_blank" rel="noopener noreferrer">DateTimeKind</a> setting is preserved.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_DateTimeExtensions.md">DateTimeExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  