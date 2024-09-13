# ConfigureErrorMessage(String, String) Method


Replaces the default error message with *errorMessage* for the error specified by *errorMessageKey*.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public void ConfigureErrorMessage(
	string errorMessageKey,
	string errorMessage
)
```
**VB**
``` VB
Public Sub ConfigureErrorMessage ( 
	errorMessageKey As String,
	errorMessage As String
)
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The key that identifies an error message.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The explicit error message string.</dd></dl>

## Remarks
This method is intended to be used for non-localizable error messages.  
 Use <a href="M_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage_1.md">ConfigureErrorMessage(String, Type, String)</a> for localizable error messages.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration.md">ErrorMessageConfiguration Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage.md">ConfigureErrorMessage Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
