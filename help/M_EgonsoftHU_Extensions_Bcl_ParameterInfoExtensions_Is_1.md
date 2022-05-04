# ParameterInfoExtensions.Is Method (ParameterInfo, Type, String)
 

Indicates whether a parameter has the specified type and name.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 1.0.3+6715e4ae393d52b571db441794d1069c783f8c2f

## Syntax

**C#**<br />
``` C#
public static bool Is(
	this ParameterInfo parameter,
	Type parameterType,
	string parameterName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Is ( 
	parameter As ParameterInfo,
	parameterType As Type,
	parameterName As String
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>parameter</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.reflection.parameterinfo" target="_blank" rel="noopener noreferrer">System.Reflection.ParameterInfo</a><br />The parameter to test.</dd><dt>parameterType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">System.Type</a><br />The expected type of the parameter.</dd><dt>parameterName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The expected name of the parameter.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />true if parameter type and name meet the expectations; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.reflection.parameterinfo" target="_blank" rel="noopener noreferrer">ParameterInfo</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ParameterInfoExtensions.md">ParameterInfoExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_ParameterInfoExtensions_Is.md">Is Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />