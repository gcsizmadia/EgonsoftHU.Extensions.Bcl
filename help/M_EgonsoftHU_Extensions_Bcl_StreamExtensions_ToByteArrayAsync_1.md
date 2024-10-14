# ToByteArrayAsync(Stream, CancellationToken) Method


Converts a stream to byte array using <a href="https://learn.microsoft.com/dotnet/api/system.io.memorystream" target="_blank" rel="noopener noreferrer">MemoryStream</a>.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static Task<byte[]> ToByteArrayAsync(
	this Stream stream,
	CancellationToken cancellationToken = default
)
```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function ToByteArrayAsync ( 
	stream As Stream,
	Optional cancellationToken As CancellationToken = Nothing
) As Task(Of Byte())
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.io.stream" target="_blank" rel="noopener noreferrer">Stream</a></dt><dd>The stream to convert.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken" target="_blank" rel="noopener noreferrer">CancellationToken</a>  (Optional)</dt><dd>The token to monitor for cancellation requests. The default value is <a href="https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken.none" target="_blank" rel="noopener noreferrer">None</a>.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.threading.tasks.task-1" target="_blank" rel="noopener noreferrer">Task</a>(<a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[])  
A byte array that contains the content of the *stream*.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.io.stream" target="_blank" rel="noopener noreferrer">Stream</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td><em>stream</em> is null.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.notsupportedexception" target="_blank" rel="noopener noreferrer">NotSupportedException</a></td>
<td><em>stream</em> does not support seeking.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_StreamExtensions.md">StreamExtensions Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_StreamExtensions_ToByteArrayAsync.md">ToByteArrayAsync Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
