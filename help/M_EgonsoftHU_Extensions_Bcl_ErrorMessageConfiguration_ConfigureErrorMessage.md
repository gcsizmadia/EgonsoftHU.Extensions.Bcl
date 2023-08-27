# ErrorMessageConfiguration.ConfigureErrorMessage Method (String, String)
 

Replaces the default error message with *errorMessage* for the error specified by *errorMessageKey*.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public void ConfigureErrorMessage(
	string errorMessageKey,
	string errorMessage
)
```

**VB**<br />
``` VB
Public Sub ConfigureErrorMessage ( 
	errorMessageKey As String,
	errorMessage As String
)
```


#### Parameters
&nbsp;<dl><dt>errorMessageKey</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The key that identifies an error message.</dd><dt>errorMessage</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The explicit error message string.</dd></dl>

## Remarks
This method is intended to be used for non-localizable error messages.<br /> Use <a href="M_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage_1.md">ConfigureErrorMessage(String, Type, String)</a> for localizable error messages.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration.md">ErrorMessageConfiguration Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage.md">ConfigureErrorMessage Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />