# ParameterInfoExtensions.Is Method (ParameterInfo, Type)
 

Indicates whether a parameter has the specified type.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.0.0+92afa6294581b57a0a05c47f5fa89680af93d830

## Syntax

**C#**<br />
``` C#
public static bool Is(
	this ParameterInfo parameter,
	Type parameterType
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Is ( 
	parameter As ParameterInfo,
	parameterType As Type
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>parameter</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.reflection.parameterinfo" target="_blank" rel="noopener noreferrer">System.Reflection.ParameterInfo</a><br />The parameter to test.</dd><dt>parameterType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">System.Type</a><br />The expected type of the parameter.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />true if parameter type meets the expectation; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.reflection.parameterinfo" target="_blank" rel="noopener noreferrer">ParameterInfo</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>Either *parameter* or *parameterType* is a null reference (`Nothing` in Visual Basic).</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ParameterInfoExtensions.md">ParameterInfoExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_ParameterInfoExtensions_Is.md">Is Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />