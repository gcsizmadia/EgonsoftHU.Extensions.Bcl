# ParameterInfoExtensions.Is(*TParameterType*) Method (ParameterInfo, String)
 

Indicates whether a parameter has the specified type and name.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+8ead0a244466e154a5be3ab837e77f44c8ca5aac

## Syntax

**C#**<br />
``` C#
public static bool Is<TParameterType>(
	this ParameterInfo parameter,
	string parameterName
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Is(Of TParameterType) ( 
	parameter As ParameterInfo,
	parameterName As String
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>parameter</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.reflection.parameterinfo" target="_blank" rel="noopener noreferrer">System.Reflection.ParameterInfo</a><br />The parameter to test.</dd><dt>parameterName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The expected name of the parameter.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TParameterType</dt><dd>The expected parameter type.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />true if parameter type and name meet the expectations; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.reflection.parameterinfo" target="_blank" rel="noopener noreferrer">ParameterInfo</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>Either *parameter* is a null reference (`Nothing` in Visual Basic) or *parameterName* is a null reference (`Nothing` in Visual Basic), <a href="https://docs.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a> or consists only of white-space characters.</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ParameterInfoExtensions.md">ParameterInfoExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_ParameterInfoExtensions_Is.md">Is Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />