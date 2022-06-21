# AssemblyExtensions.SafeGetCodeBase Method 
 

**Note: This API is now obsolete.**

Gets the location of the assembly as specified originally, for example, in an <a href="https://docs.microsoft.com/dotnet/api/system.reflection.assemblyname" target="_blank" rel="noopener noreferrer">AssemblyName</a> object.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+8ead0a244466e154a5be3ab837e77f44c8ca5aac

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("This method uses Assembly.CodeBase property that is only included for .NET Framework compatibility. Use AssemblyExtensions.SafeGetLocation(Assembly) extension method instead.")]
public static string SafeGetCodeBase(
	this Assembly? assembly
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("This method uses Assembly.CodeBase property that is only included for .NET Framework compatibility. Use AssemblyExtensions.SafeGetLocation(Assembly) extension method instead.")>
Public Shared Function SafeGetCodeBase ( 
	assembly As Assembly
) As String
```


#### Parameters
&nbsp;<dl><dt>assembly</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.reflection.assembly" target="_blank" rel="noopener noreferrer">System.Reflection.Assembly</a><br /></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a><br />The location of the assembly as specified originally. 
If the assembly is null or a dynamic assembly (represented by an System.Reflection.Emit.AssemblyBuilder object), the value returned is an empty string ("").


#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.reflection.assembly" target="_blank" rel="noopener noreferrer">Assembly</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
In case of .NET Core and .NET 5+ <br />- the <a href="https://docs.microsoft.com/dotnet/api/system.reflection.assembly.codebase#system-reflection-assembly-codebase" target="_blank" rel="noopener noreferrer">CodeBase</a> property always throws <a href="https://docs.microsoft.com/dotnet/api/system.notimplementedexception" target="_blank" rel="noopener noreferrer">NotImplementedException</a><br />- this method always returns <a href="https://docs.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_AssemblyExtensions.md">AssemblyExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />