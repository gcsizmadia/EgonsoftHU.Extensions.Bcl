# ErrorMessageConfiguration.ConfigureErrorMessage Method (String, Type, String)
 

Replaces the default error message for the error specified by *errorMessageKey* using resource.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public void ConfigureErrorMessage(
	string errorMessageKey,
	Type errorMessageResourceType,
	string? errorMessageResourceName = null
)
```

**VB**<br />
``` VB
Public Sub ConfigureErrorMessage ( 
	errorMessageKey As String,
	errorMessageResourceType As Type,
	Optional errorMessageResourceName As String = Nothing
)
```


#### Parameters
&nbsp;<dl><dt>errorMessageKey</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The key that identifies an error message.</dd><dt>errorMessageResourceType</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">System.Type</a><br />The resource type to use for error message lookups.</dd><dt>errorMessageResourceName (Optional)</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">System.String</a><br />The resource name (property name) to use as the key for lookups on the resource type.</dd></dl>

## Remarks
This method is intended to be used for localizable error messages.<br /> Use <a href="M_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage.md">ConfigureErrorMessage(String, String)</a> for non-localized error messages. 
If *errorMessageResourceName* is a null reference (`Nothing` in Visual Basic), <a href="https://learn.microsoft.com/dotnet/api/system.string.empty#system-string-empty" target="_blank" rel="noopener noreferrer">Empty</a>, or if *errorMessageResourceName* consists exclusively of white-space characters then the value of *errorMessageKey* will be used.


## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration.md">ErrorMessageConfiguration Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage.md">ConfigureErrorMessage Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />