# SetHttpStatusCode&lt;TException&gt; Method


Sets the HTTP status code for an exception.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public static TException SetHttpStatusCode<TException>(
	this TException ex,
	int httpStatusCode
)
where TException : Exception

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function SetHttpStatusCode(Of TException As Exception) ( 
	ex As TException,
	httpStatusCode As Integer
) As TException
```



#### Parameters
<dl><dt>  TException</dt><dd>The exception for which the HTTP status code will be set.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>The HTTP status code to set.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the exception.</dd></dl>

#### Return Value
TException  
A reference to the <a href="https://learn.microsoft.com/dotnet/api/system.exception" target="_blank" rel="noopener noreferrer">Exception</a> instance (specified by the *ex* parameter) this extension method was called on.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type TException. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ExceptionExtensions.md">ExceptionExtensions Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
