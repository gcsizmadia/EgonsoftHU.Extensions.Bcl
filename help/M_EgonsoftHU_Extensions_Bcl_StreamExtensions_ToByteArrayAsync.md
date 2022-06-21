# StreamExtensions.ToByteArrayAsync Method 
 

Converts a stream to byte array using <a href="https://docs.microsoft.com/dotnet/api/system.io.memorystream" target="_blank" rel="noopener noreferrer">MemoryStream</a>.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+8ead0a244466e154a5be3ab837e77f44c8ca5aac

## Syntax

**C#**<br />
``` C#
public static Task<byte[]> ToByteArrayAsync(
	this Stream stream,
	CancellationToken cancellationToken = default
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ToByteArrayAsync ( 
	stream As Stream,
	Optional cancellationToken As CancellationToken = Nothing
) As Task(Of Byte())
```


#### Parameters
&nbsp;<dl><dt>stream</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_blank" rel="noopener noreferrer">System.IO.Stream</a><br />The stream to convert.</dd><dt>cancellationToken (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.threading.cancellationtoken" target="_blank" rel="noopener noreferrer">System.Threading.CancellationToken</a><br />The token to monitor for cancellation requests. The default value is <a href="https://docs.microsoft.com/dotnet/api/system.threading.cancellationtoken.none#system-threading-cancellationtoken-none" target="_blank" rel="noopener noreferrer">None</a>.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1" target="_blank" rel="noopener noreferrer">Task</a>(<a href="https://docs.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[])<br />A byte array that contains the content of the *stream*.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.io.stream" target="_blank" rel="noopener noreferrer">Stream</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>*stream* is a null reference (`Nothing` in Visual Basic).</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.notsupportedexception" target="_blank" rel="noopener noreferrer">NotSupportedException</a></td><td>*stream* does not support seeking.</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_StreamExtensions.md">StreamExtensions Class</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />