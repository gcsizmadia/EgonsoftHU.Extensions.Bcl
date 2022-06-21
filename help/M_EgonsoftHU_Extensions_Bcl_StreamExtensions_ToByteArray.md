# StreamExtensions.ToByteArray Method 
 

Converts a stream to byte array using <a href="https://docs.microsoft.com/dotnet/api/system.io.memorystream" target="_blank" rel="noopener noreferrer">MemoryStream</a>.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+92afa6294581b57a0a05c47f5fa89680af93d830

## Syntax

**C#**<br />
``` C#
public static byte[] ToByteArray(
	this Stream stream
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ToByteArray ( 
	stream As Stream
) As Byte()
```


#### Parameters
&nbsp;<dl><dt>stream</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_blank" rel="noopener noreferrer">System.IO.Stream</a><br />The stream to convert.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]<br />A byte array that contains the content of the *stream*.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_blank" rel="noopener noreferrer">Stream</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>*stream* is a null reference (`Nothing` in Visual Basic).</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.notsupportedexception" target="_blank" rel="noopener noreferrer">NotSupportedException</a></td><td>*stream* does not support seeking.</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_StreamExtensions.md">StreamExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />