# AssemblyExtensions.SafeGetLocation Method 
 

Gets the full path or UNC location of the loaded file that contains the manifest.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 1.0.3+6715e4ae393d52b571db441794d1069c783f8c2f

## Syntax

**C#**<br />
``` C#
public static string SafeGetLocation(
	this Assembly assembly
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function SafeGetLocation ( 
	assembly As Assembly
) As String
```


#### Parameters
&nbsp;<dl><dt>assembly</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.reflection.assembly" target="_blank" rel="noopener noreferrer">System.Reflection.Assembly</a><br />The assembly the location of which</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a><br />
The location of the loaded file that contains the manifest. If the loaded file was shadow-copied, the location is that of the file after being shadow-copied.

If the assembly is loaded from a byte array, such as when using the <a href="https://docs.microsoft.com/dotnet/api/system.reflection.assembly.load#system-reflection-assembly-load(system-byte())" target="_blank" rel="noopener noreferrer">Load(Byte[])</a> method overload, the value returned is an empty string ("").

If the assembly is null or a dynamic assembly (represented by an System.Reflection.Emit.AssemblyBuilder object), the value returned is an empty string ("").


#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.reflection.assembly" target="_blank" rel="noopener noreferrer">Assembly</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_AssemblyExtensions.md">AssemblyExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />