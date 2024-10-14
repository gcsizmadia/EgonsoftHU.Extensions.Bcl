# SafeGetCodeBase Method


Gets the location of the assembly as specified originally, for example, in an <a href="https://learn.microsoft.com/dotnet/api/system.reflection.assemblyname" target="_blank" rel="noopener noreferrer">AssemblyName</a> object.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static string SafeGetCodeBase(
	this Assembly? assembly
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function SafeGetCodeBase ( 
	assembly As Assembly
) As String
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.reflection.assembly" target="_blank" rel="noopener noreferrer">Assembly</a></dt><dd /></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
The location of the assembly as specified originally. 
If the assembly is null or a dynamic assembly (represented by an System.Reflection.Emit.AssemblyBuilder object), the value returned is an empty string ("").


#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.reflection.assembly" target="_blank" rel="noopener noreferrer">Assembly</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Remarks
In case of .NET Core and .NET 5+   
- the <a href="https://learn.microsoft.com/dotnet/api/system.reflection.assembly.codebase" target="_blank" rel="noopener noreferrer">CodeBase</a> property always throws <a href="https://learn.microsoft.com/dotnet/api/system.notimplementedexception" target="_blank" rel="noopener noreferrer">NotImplementedException</a>  
- this method always returns <a href="https://learn.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_AssemblyExtensions.md">AssemblyExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
